using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liverpool.DAL;
using Liverpool.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Liverpool.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Employee : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public Employee(DB_Liverpool context,
                                 UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signinManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signinManager = signinManager;
            _roleManager = roleManager;
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
            ViewBag.Count = _context.Users.Count();
            IEnumerable<AppUser> users = _context.Users.OrderByDescending(p => p.Id).Take(10);
            return View(users);
        }
    }
}