using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liverpool.DAL;
using Liverpool.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace Liverpool.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FirstTeamController : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly IHostingEnvironment _env;

        public FirstTeamController(DB_Liverpool context,
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

            return View(_context.FirstTeam);
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

            ViewBag.Player = _context.Player;
            
            FirstTeam team = await _context.FirstTeam.FindAsync(id);

            if (team == null) return View("Error");
            return View(team);
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

            ViewBag.Players = _context.Player;

            FirstTeam team = _context.FirstTeam.Find(id);

            return View(team);
        }

        [ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(FirstTeam team)
        {
            if (!User.Identity.IsAuthenticated)
            {
                ViewBag.Players = _context.Player;
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                ViewBag.Players = _context.Player;
                return RedirectToAction("Login", "Account");
            }
            if (!ModelState.IsValid)
            {
                ViewBag.Players = _context.Player;
                ModelState.AddModelError("", "Xaiş olunur düzgün doldurun.");
                return View(team);
            }

            FirstTeam newTeam = await _context.FirstTeam.FindAsync(team.Id);

            if (newTeam == null) return View("Error");

            newTeam.PlayerId = team.PlayerId;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}