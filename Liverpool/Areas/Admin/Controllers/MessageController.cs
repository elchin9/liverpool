using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liverpool.DAL;
using Liverpool.Models;
using Microsoft.AspNetCore.Mvc;

namespace Liverpool.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly DB_Liverpool _context;

        public MessageController(DB_Liverpool context)
        {
            _context = context;
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
            ViewBag.Active = "Site";
            ViewBag.Count = _context.MailBox.Count();
            return View(_context.MailBox.OrderByDescending(m => m.Id).Take(10));
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

            MailBox message = await _context.MailBox.FindAsync(id);

            if (message == null) return View("Error");
            ViewBag.Active = "Site";


            return View(message);
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

            MailBox message = await _context.MailBox.FindAsync(id);

            if (message == null) return View("Error");
            ViewBag.Active = "Site";


            return View(message);
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
            MailBox message = await _context.MailBox.FindAsync(id);

            _context.MailBox.Remove(message);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}