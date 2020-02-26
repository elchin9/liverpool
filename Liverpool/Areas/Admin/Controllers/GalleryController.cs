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
    public class GalleryController : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly IHostingEnvironment _env;

        public GalleryController(DB_Liverpool context,
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
            ViewBag.Count = _context.Gallery.Count();
            IEnumerable<Gallery> gallery = _context.Gallery.OrderByDescending(p => p.Id).Take(10);
            return View(gallery);
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

            Gallery gallery = await _context.Gallery.FindAsync(id);

            if (gallery == null) return View("Error");
            return View(gallery);
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

            Gallery gallery = await _context.Gallery.FindAsync(id);

            if (gallery == null) return View("Error");
            return View(gallery);
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
            Gallery gallery = await _context.Gallery.FindAsync(id);

            string computerPhoto = Path.Combine(_env.WebRootPath, "images", gallery.PhotoURL);

            if (System.IO.File.Exists(computerPhoto))
            {
                System.IO.File.Delete(computerPhoto);
            }
            _context.Gallery.Remove(gallery);

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
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Gallery gallery)
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

                return View(gallery);
            }

            if (gallery.Photo == null)
            {
                ViewBag.Active = "Home";

                return View(gallery);
            }

            foreach(var p in gallery.Photo)
            {
                string fileName = await p.SaveAsync(_env.WebRootPath, "gallery");

                Gallery newGallery = new Gallery()
                {
                    PhotoURL = fileName
                };

                await _context.Gallery.AddAsync(newGallery);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}