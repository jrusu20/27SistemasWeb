using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using SistemasWeb.Areas.Cursos.Models;
using SistemasWeb.Data;
using SistemasWeb.Library;
using SistemasWeb.Models;

namespace SistemasWeb.Controllers
{
    public class HomeController : Controller
    {
        private LCursos _curso;
        private static DataPaginador<TCursos> models;

       // private readonly IServiceProvider serviceProvider;

        public HomeController(ApplicationDbContext context,IServiceProvider _serviceProvider)
        {
            // serviceProvider = _serviceProvider;
            _curso = new LCursos(context, null);
        }
         
        public IActionResult Index(int id, String Search)
        {
            Object[] objects = new object[3];
            var data = _curso.getTCursos(Search);
            if (0<data.Count)
            {
                var url = Request.Scheme + "://" + Request.Host.Value;
                objects= new LPaginador<TCursos>().paginador(data, id, 5, "", "Home", "Index", url);
            }
            else
            {
                objects[0] = "No hay datos para mostrar";
                objects[1] = "No hay datos para mostrar";
                objects[2] = new List<TCursos>();
            }
            models = new DataPaginador<TCursos>
            {
                List = (List<TCursos>)objects[2],
                Pagi_info = (String)objects[0],
                Pagi_navegacion = (String)objects[1],
                Input = new TCursos()
            };
            //await CreateRolesAsync(serviceProvider);
            return View(models);
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
