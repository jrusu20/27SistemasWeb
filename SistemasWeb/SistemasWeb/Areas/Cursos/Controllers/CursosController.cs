using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SistemasWeb.Areas.Cursos.Models;
using SistemasWeb.Data;
using SistemasWeb.Library;
using SistemasWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasWeb.Areas.Cursos.Controllers
{
    public class CursosController : Controller
    {
        private  ApplicationDbContext context;
        private  SignInManager<IdentityUser> signInManager;
        private LCategorias _lCategorias;
        private static DataPaginador<TCursos> models;
        private static IdentityError identityError;



        public CursosController(ApplicationDbContext _context,SignInManager<IdentityUser> _signInManager)
        {
            context = _context;
            signInManager = _signInManager;
            _lCategorias = new LCategorias(context);
        }

        [Area("Cursos")]
        public IActionResult Cursos()
        {
            if (signInManager.IsSignedIn(User))
            {
                models = new DataPaginador<TCursos>
                {
                    Categorias=_lCategorias.getTCategorias(),
                    Input=new TCursos()
                };
                return View(models);
            }
            else
            {
                return Redirect("/Home/Index");
            }
       
        }
    }
}
