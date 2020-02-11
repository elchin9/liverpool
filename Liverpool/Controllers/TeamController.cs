using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liverpool.DAL;
using Liverpool.Models;
using Liverpool.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Liverpool.Controllers
{
    public class TeamController : Controller
    {
        private readonly DB_Liverpool _context;

        public TeamController(DB_Liverpool context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Active = "Club";
            TeamViewModel viewModel = new TeamViewModel()
            {
                Image = _context.BackgroundImages.FirstOrDefault(),
                Position = _context.Position,
                Players = _context.Player,
                FirstTeam = _context.FirstTeam
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.Active = "Club";
            if (id == null) return View("Error");

            Player player = await _context.Player.FindAsync(id);

            if (player == null) return View("Error");

            return View(player);
        }
    }
}