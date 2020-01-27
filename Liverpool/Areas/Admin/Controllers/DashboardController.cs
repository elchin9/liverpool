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
    public class DashboardController : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly IHostingEnvironment _env;

        public DashboardController(DB_Liverpool context, IHostingEnvironment env)
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

            return View();
        }

        public IActionResult Website()
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

        public IActionResult Club()
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

        public IActionResult ImageIndex()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            return View(_context.BackgroundImages.FirstOrDefault());
        }

        [ActionName("Edit")]
        public async Task<IActionResult> Edit(int? id)
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
            BackgroundImages image = await _context.BackgroundImages.FindAsync(id);
            return View(image);
        }

        [ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(BackgroundImages image)
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
                return View(image);
            }

            BackgroundImages currentImages = await _context.BackgroundImages.FindAsync(image.Id);

            if (image.CupPhoto != null)
            {
                string computerPhoto = Path.Combine(_env.WebRootPath, "images", currentImages.CupPhotoURL);
                if (System.IO.File.Exists(computerPhoto))
                {
                    System.IO.File.Delete(computerPhoto);
                }
                if (image.CupPhoto.ContentType.Contains("image/"))
                {
                    string filename = await image.CupPhoto.SaveWithoutFolderAsync(_env.WebRootPath);
                    currentImages.CupPhotoURL = filename;
                }

            }
            if (image.HistoryPhoto != null)
            {

                string computerPhoto = Path.Combine(_env.WebRootPath, "images", currentImages.HistoryPhotoURL);

                if (System.IO.File.Exists(computerPhoto))
                {
                    System.IO.File.Delete(computerPhoto);
                }

                if (image.HistoryPhoto.ContentType.Contains("image/"))
                {
                    string filename = await image.HistoryPhoto.SaveWithoutFolderAsync(_env.WebRootPath);

                    currentImages.HistoryPhotoURL = filename;

                }

            }
            if (image.SquadPhoto != null)
            {
                string computerPhoto = Path.Combine(_env.WebRootPath, "images", currentImages.SquadPhotoURL);
                if (System.IO.File.Exists(computerPhoto))
                {
                    System.IO.File.Delete(computerPhoto);
                }
                if (image.SquadPhoto.ContentType.Contains("image/"))
                {
                    string filename = await image.SquadPhoto.SaveWithoutFolderAsync(_env.WebRootPath);
                    currentImages.SquadPhotoURL = filename;
                }
            }
            if (image.StadiumPhoto != null)
            {
                string computerPhoto = Path.Combine(_env.WebRootPath, "images", currentImages.StadiumPhotoURL);
                if (System.IO.File.Exists(computerPhoto))
                {
                    System.IO.File.Delete(computerPhoto);
                }
                if (image.StadiumPhoto.ContentType.Contains("image/"))
                {
                    string filename = await image.StadiumPhoto.SaveWithoutFolderAsync(_env.WebRootPath);
                    currentImages.StadiumPhotoURL = filename;
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("ImageIndex");
        }
    }
}