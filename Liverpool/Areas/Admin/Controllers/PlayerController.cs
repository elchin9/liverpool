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
    public class PlayerController : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly IHostingEnvironment _env;

        public PlayerController(DB_Liverpool context,
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

            return View(_context.Player);
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

            Player player = await _context.Player.FindAsync(id);

            if (player == null) return View("Error");
            return View(player);
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

            Player player = await _context.Player.FindAsync(id);

            if (player == null) return View("Error");
            return View(player);
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
            Player player = await _context.Player.FindAsync(id);

            string computerPhoto = Path.Combine(_env.WebRootPath, "images", player.PhotoURL);

            if (System.IO.File.Exists(computerPhoto))
            {
                System.IO.File.Delete(computerPhoto);
            }
            _context.Player.Remove(player);

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
            ViewBag.Position = _context.Position;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Player player)
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

                return View(player);
            }

            if (player.Photo == null || player.BackgroundPhoto == null)
            {
                ViewBag.Active = "Home";

                return View(player);
            }
            string fileName = await player.Photo.SaveAsync(_env.WebRootPath, "players");
            string fileNameBackground = await player.BackgroundPhoto.SaveAsync(_env.WebRootPath, "players");


            Player newPlayer = new Player()
            {
                Firstname = player.Firstname,
                Lastname = player.Lastname,
                Country = player.Country,
                Birthday = player.Birthday,
                Info = player.Info,
                PositionId = player.PositionId,
                PhotoURL = fileName,
                BackgroundPhotoURL = fileNameBackground
            };

            await _context.Player.AddAsync(newPlayer);
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

            ViewBag.Position = _context.Position;

            Player player = _context.Player.Find(id);

            return View(player);
        }

        [ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(Player player)
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
                return View(player);
            }

            Player newPlayer = await _context.Player.FindAsync(player.Id);

            if (newPlayer == null) return View("Error");

            newPlayer.Firstname = player.Firstname;
            newPlayer.Lastname = player.Lastname;
            newPlayer.Info = player.Info;
            newPlayer.Birthday = player.Birthday;
            newPlayer.Country = player.Country;
            newPlayer.PositionId = player.PositionId;

            if (player.Photo != null)
            {
                string computerPhoto = Path.Combine(_env.WebRootPath, "images", newPlayer.PhotoURL);

                if (System.IO.File.Exists(computerPhoto))
                {
                    System.IO.File.Delete(computerPhoto);
                }

                string fileName = await player.Photo.SaveAsync(_env.WebRootPath, "players");
                player.PhotoURL = fileName;
            }
            if (player.BackgroundPhoto != null)
            {
                string computerPhoto = Path.Combine(_env.WebRootPath, "images", newPlayer.BackgroundPhotoURL);

                if (System.IO.File.Exists(computerPhoto))
                {
                    System.IO.File.Delete(computerPhoto);
                }

                string fileName = await player.BackgroundPhoto.SaveAsync(_env.WebRootPath, "players");
                player.BackgroundPhotoURL = fileName;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}