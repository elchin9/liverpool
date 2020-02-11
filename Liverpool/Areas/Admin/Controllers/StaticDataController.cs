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
    public class StaticDataController : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly IHostingEnvironment _env;

        public StaticDataController(DB_Liverpool context,
                                       IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public async Task<IActionResult> Details()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            if (!User.IsInRole("Admin"))
            {
                return RedirectToAction("Login", "Account");
            }
            return View(_context.StaticData.FirstOrDefault());
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

            StaticData staticData = _context.StaticData.Find(id);

            return View(staticData);
        }

        [ActionName("Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPost(StaticData staticData)
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
                return View(staticData);
            }

            StaticData currentData = await _context.StaticData.FindAsync(staticData.Id);

            if (currentData == null) return View("Error");

            currentData.Email = staticData.Email;
            currentData.FacebookLink = staticData.FacebookLink;
            currentData.InstagramLink = staticData.InstagramLink;
            currentData.Phone = staticData.Phone;
            currentData.TwitterLink = staticData.TwitterLink;
            currentData.YoutubeLink = staticData.YoutubeLink;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Details));
        }
    }
}