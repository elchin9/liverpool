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
    public class NewsController : Controller
    {
        private readonly DB_Liverpool _context;

        public NewsController(DB_Liverpool context)
        {
            _context = context;
        }

        public IActionResult Index(string news)
        {
            ViewBag.NewsCount = _context.News.Count();
            ViewBag.Active = "News";
            return View(_context.News.OrderByDescending(n => n.Id).Take(16));
        }

        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.Active = "News";
            if (id == null) return View("Error");

            News news = await _context.News.FindAsync(id);

            if (news == null) return View("Error");

            NewsViewModel viewModel = new NewsViewModel()
            {
                News = news,
                AllNews = _context.News.OrderByDescending(n => n.Id).Where(n => n.Id != news.Id).Take(4)
            };

            return View(viewModel);
        }
    }
}