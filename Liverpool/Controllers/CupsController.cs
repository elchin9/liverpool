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
    public class CupsController : Controller
    {
        private readonly DB_Liverpool _context;

        public CupsController(DB_Liverpool context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Active = "Club";
            CupViewModel viewModel = new CupViewModel()
            {
                Image = _context.BackgroundImages.FirstOrDefault(),
                CupType = _context.CupType,
                AllCups = _context.Cup
            };

            return View(viewModel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.Active = "Club";
            if (id == null) return View("Error");

            Cup cup = await _context.Cup.FindAsync(id);
            if (cup == null) return View("Error");

            return View(cup);
        }
    }
}