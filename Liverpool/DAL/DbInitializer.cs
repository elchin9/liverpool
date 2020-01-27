
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Liverpool.Models;
using Liverpool.DAL;
using Liverpool.Utilities;


namespace Liverpool.DAL
{
    public class DbInitializer
    {
        public async static Task Seed(DB_Liverpool _context, UserManager<AppUser> userManager,
                                                                    RoleManager<IdentityRole> roleManager,
                                                                    IConfiguration configuration)
        {
            await _context.Database.EnsureCreatedAsync();
            if (!await roleManager.RoleExistsAsync(StaticUsers.Admin))
            {
                await roleManager.CreateAsync(new IdentityRole(StaticUsers.Admin));
            }

            if (!await roleManager.RoleExistsAsync(StaticUsers.Moderator))
            {
                await roleManager.CreateAsync(new IdentityRole(StaticUsers.Moderator));
            }

            if (await userManager.FindByNameAsync("Admin") == null)
            {
                var admin = new AppUser()
                {
                    Firstname = "Admin",
                    Lastname = "Admin",
                    Email = "ElchinSh@code.edu.az",
                    UserName = "admin",
                };

                var result = await userManager.CreateAsync(admin, "Admin123!");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, StaticUsers.Admin);
                }
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, StaticUsers.Admin);
                }
            }
        }
    }
}
