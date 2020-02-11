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
    public class VideoController : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly IHostingEnvironment _env;

        public VideoController(DB_Liverpool context,
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

            return View(_context.Video);
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

            Video myVideo = await _context.Video.FindAsync(id);

            if (myVideo == null) return View("Error");
            return View(myVideo);
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

            Video myVideo = await _context.Video.FindAsync(id);

            if (myVideo == null) return View("Error");
            return View(myVideo);
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
            Video myVideo = await _context.Video.FindAsync(id);

            string computerPhoto = Path.Combine(_env.WebRootPath, "images", myVideo.PhotoURL);

            if (System.IO.File.Exists(computerPhoto))
            {
                System.IO.File.Delete(computerPhoto);
            }
            _context.Video.Remove(myVideo);

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
            ViewBag.VideoCategory = _context.VideoCategory;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Video myVideo)
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

                return View(myVideo);
            }

            if (myVideo.Photo == null)
            {
                return View(myVideo);
            }
            string fileName = await myVideo.Photo.SaveAsync(_env.WebRootPath, "video");

            Video newVideo = new Video()
            {
               Title = myVideo.Title,
               VideoLink = myVideo.VideoLink,
               MainInfo = myVideo.MainInfo,
               PhotoURL = fileName,
               Time = myVideo.Time,
               CategoryId = myVideo.CategoryId
            };

            await _context.Video.AddAsync(newVideo);
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

            ViewBag.VideoCategory = _context.VideoCategory;

            Video myVideo = _context.Video.Find(id);

            return View(myVideo);
        }

        [ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Video myVideo)
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
                return View(myVideo);
            }

            Video currentVideo = await _context.Video.FindAsync(myVideo.Id);

            if (currentVideo == null) return View("Error");

            currentVideo.Title = myVideo.Title;
            currentVideo.MainInfo = myVideo.MainInfo;
            currentVideo.Time = myVideo.Time;
            currentVideo.VideoLink = myVideo.VideoLink;
            currentVideo.CategoryId = myVideo.CategoryId;

            if (myVideo.Photo != null)
            {
                string computerPhoto = Path.Combine(_env.WebRootPath, "images", currentVideo.PhotoURL);

                if (System.IO.File.Exists(computerPhoto))
                {
                    System.IO.File.Delete(computerPhoto);
                }

                string fileName = await myVideo.Photo.SaveAsync(_env.WebRootPath, "video");
                currentVideo.PhotoURL = fileName;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}