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
    public class ClubController : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly IHostingEnvironment _env;

        public ClubController(DB_Liverpool context,
                                       IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult GetHistory()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
 
            return View(_context.History.FirstOrDefault());
        }

        public IActionResult GetStadium()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }

            return View(_context.Stadium.FirstOrDefault());
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

            History history = _context.History.Find(id);

            return View(history);
        }

        [ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(History history)
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
                return View(history);
            }
            History newHistory = await _context.History.FindAsync(history.Id);
            if (newHistory == null) return View("Error");
            newHistory.Info = history.Info;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetHistory));
        }

        [ActionName("EditStadium")]
        public IActionResult EditStadium(int? id)
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

            Stadium stadium = _context.Stadium.Find(id);

            return View(stadium);
        }

        [ActionName("EditStadium")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditStadiumPost(Stadium stadium)
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
                return View(stadium);
            }
            Stadium newStadium = await _context.Stadium.FindAsync(stadium.Id);
            if (newStadium == null) return View("Error");

            newStadium.Capacity = stadium.Capacity;
            newStadium.MainInfo = stadium.MainInfo;
            newStadium.Name = stadium.Name;
            newStadium.Time = stadium.Time;

            if (stadium.AllPhotos != null)
            {
                IEnumerable<StadiumPhotos> myPhoto = newStadium.Photos.Where(b => b.StadiumId == newStadium.Id);

                foreach (var photo in myPhoto)
                {
                    string computerPhoto = Path.Combine(_env.WebRootPath, "images", photo.PhotoURL);

                    if (System.IO.File.Exists(computerPhoto))
                    {
                        System.IO.File.Delete(computerPhoto);
                    }
                    _context.StadiumPhotos.RemoveRange(myPhoto);
                }
                foreach (var p in stadium.AllPhotos)
                {
                    if (p != null)
                    {
                        if (p.ContentType.Contains("image/"))
                        {
                            string filename = await p.SaveAsync(_env.WebRootPath, "stadium");

                            StadiumPhotos img = new StadiumPhotos()
                            {
                                StadiumId = newStadium.Id,
                                PhotoURL = filename
                            };
                            await _context.StadiumPhotos.AddAsync(img);
                        }
                    }
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetStadium));
        }
    }
}