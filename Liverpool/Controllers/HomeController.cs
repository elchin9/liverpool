using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Liverpool.Models;
using Liverpool.ViewModel;
using Liverpool.DAL;

namespace Liverpool.Controllers
{
    public class HomeController : Controller
    {
        private readonly DB_Liverpool _context;

        public HomeController(DB_Liverpool context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel()
            {
                Sliders = _context.Slider,
                Videos = _context.Video.OrderByDescending(v => v.Id).Take(4),
                News = _context.News.OrderByDescending(v => v.Id).Take(4),
                Event = _context.Event.OrderByDescending(e => e.Id).FirstOrDefault()
            };
            ViewBag.Active = "Home";

            return View(viewModel);
        }

        public IActionResult Contact()
        {
            ViewBag.Active = "Contact";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Contact(MailBox message)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Active = "Contact";

                return View(message);
            }
            MailBox mynews = new MailBox()
            {
                Firstname = message.Firstname,
                Lastname = message.Lastname,
                Email = message.Email,
                TextBody = message.TextBody,
                Time = DateTime.Now
            };

            await _context.MailBox.AddAsync(mynews);
            await _context.SaveChangesAsync();

            TempData["MessageSent"] = true;
            return RedirectToAction(nameof(Contact));
        }


        public IActionResult Gallery()
        {
            ViewBag.Active = "FanClub";
            ViewBag.ImageCount = _context.Gallery.Count();
            return View(_context.Gallery.OrderByDescending(g => g.Id).Take(20));
        }

        public IActionResult Events()
        {
            ViewBag.Active = "FanClub";
            ViewBag.EventCount = _context.Event.Where(e => e.Time > DateTime.Now).Count();
            var model = _context.Event.Where(e => e.Time > DateTime.Now)
                                      .OrderByDescending(e => e.Id)
                                      .Take(2);
            return View(model);
        }

        public IActionResult History()
        {
            ViewBag.Active = "Club";
            HistoryViewModel viewModel = new HistoryViewModel()
            {
                Image = _context.BackgroundImages.FirstOrDefault(),
                History = _context.History.FirstOrDefault()
            };
            return View(viewModel);
        }

        public IActionResult Stadium()
        {
            ViewBag.Active = "Club";
            ViewBag.StadiumCount = _context.StadiumPhotos.Count();
            StadiumViewModel viewModel = new StadiumViewModel()
            {
                Image = _context.BackgroundImages.FirstOrDefault(),
                Stadium = _context.Stadium.FirstOrDefault()
            };
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
