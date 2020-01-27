using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liverpool.DAL;
using Liverpool.Models;
using Liverpool.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Liverpool.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly DB_Liverpool _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(DB_Liverpool context,
                                 UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signinManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _signinManager = signinManager;
            _roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel LoginViewModel)
        {
            if (!ModelState.IsValid) return View(LoginViewModel);

            AppUser user = await _userManager.FindByEmailAsync(LoginViewModel.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email or password is invalid");
                return View(LoginViewModel);
            }

            Microsoft.AspNetCore.Identity.SignInResult signInResult =
                 await _signinManager.PasswordSignInAsync(user, LoginViewModel.Password, LoginViewModel.RememberMe, true);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is invalid");
                return View(LoginViewModel);
            }
            return RedirectToAction("Index", "Dashboard");
        }

        public async Task<IActionResult> Logout()
        {
            await _signinManager.SignOutAsync();

            return RedirectToAction("Login", "Account");
        }

    }
}