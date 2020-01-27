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
    public class VideoController : Controller
    {
        private readonly DB_Liverpool _context;

        public VideoController(DB_Liverpool context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Count = _context.Video.Count();

            return View(_context.Video.OrderByDescending(v => v.Id).Take(12));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return View("Error");

            Video video = await _context.Video.FindAsync(id);

            if (video == null) return View("Error");

            VideoViewModel viewModel = new VideoViewModel()
            {
                OneVideo = video,
                Videos = _context.Video.OrderByDescending(v => v.Id).Take(12)
            };

            return View(viewModel);
        }
    }
}