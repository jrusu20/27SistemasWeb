using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SistemasWeb.Models;

namespace SistemasWeb.Controllers
{
    public class HomeController : Controller
    {
       // private readonly IServiceProvider serviceProvider;

        public HomeController(IServiceProvider _serviceProvider)
        {
           // serviceProvider = _serviceProvider;
        }
         
        public IActionResult Index()
        {
             //await CreateRolesAsync(serviceProvider);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task CreateRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.
                GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.
                GetRequiredService<UserManager<IdentityUser>>();

            String[] rolesName = { "Admin", "Student" };
            foreach (var item in rolesName)
            {
               var roleExists= await roleManager.RoleExistsAsync(item);
                if (!roleExists)
                {
                    await roleManager.CreateAsync(new IdentityRole(item));

                }
            }
            var user = await userManager.
                FindByIdAsync("97a4a824-70d8-4e87-98c4-2e31788642aa");
            await userManager.AddToRoleAsync(user, "Admin");


        }
    }
}
