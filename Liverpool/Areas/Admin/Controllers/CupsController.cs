using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Liverpool.DAL;
using Liverpool.Extensions;
using Liverpool.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Liverpool.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CupsController : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly IHostingEnvironment _env;

        public CupsController(DB_Liverpool context,
                                       IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            ViewBag.Active = "Home";
            ViewBag.Count = _context.Cup.Count();
            IEnumerable<Cup> cups = _context.Cup.OrderByDescending(p => p.Id).Take(10);
            return View(cups);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            if (id == null) return View("Error");

            Cup cup = await _context.Cup.FindAsync(id);

            if (cup == null) return View("Error");
            ViewBag.Active = "Home";


            return View(cup);
        }

        [ActionName("Delete")]
        public async Task<IActionResult> DeleteGet(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            if (id == null) return View("Error");

            Cup cup = await _context.Cup.FindAsync(id);

            if (cup == null) return View("Error");
            ViewBag.Active = "Home";

            return View(cup);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            Cup cup = await _context.Cup.FindAsync(id);

            string computerPhoto = Path.Combine(_env.WebRootPath, "images", cup.BackgroundPhotoURL);

            if (System.IO.File.Exists(computerPhoto))
            {
                System.IO.File.Delete(computerPhoto);
            }
            _context.Cup.Remove(cup);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }

            ViewBag.Active = "Home";
            ViewBag.CupType = _context.CupType;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cup cup)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Active = "Home";

                return View(cup);
            }

            if (cup.Photo == null)
            {
                ViewBag.Active = "Home";

                return View(cup);
            }
            string fileName = await cup.Photo.SaveAsync(_env.WebRootPath, "cups");

            Cup newCup = new Cup()
            {
                Place = cup.Place,
                Time = cup.Time,
                Info = cup.Info,
                BackgroundPhotoURL = fileName,
                CupTypeId = cup.CupTypeId
            };

            await _context.Cup.AddAsync(newCup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [ActionName("Edit")]
        public IActionResult Edit(int? id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            if (id == null) return View("Error");

            ViewBag.CupType = _context.CupType;

            Cup cup = _context.Cup.Find(id);

            return View(cup);
        }

        [ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Cup cup)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Xaiş olunur düzgün doldurun.");
                return View(cup);
            }

            Cup newCup = await _context.Cup.FindAsync(cup.Id);

            if (newCup == null) return View("Error");

            newCup.Place = cup.Place;
            newCup.Info = cup.Info;
            newCup.Time = cup.Time;
            newCup.CupTypeId = cup.CupTypeId;
            
            if(cup.Photo != null)
            {
                string computerPhoto = Path.Combine(_env.WebRootPath, "images", newCup.BackgroundPhotoURL);

                if (System.IO.File.Exists(computerPhoto))
                {
                    System.IO.File.Delete(computerPhoto);
                }

                string fileName = await cup.Photo.SaveAsync(_env.WebRootPath, "cups");
                newCup.BackgroundPhotoURL = fileName;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}