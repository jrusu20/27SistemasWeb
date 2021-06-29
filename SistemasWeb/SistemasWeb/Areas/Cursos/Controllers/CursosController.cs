using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
        private LCursos _cursos;
        private  ApplicationDbContext context;
        private  SignInManager<IdentityUser> signInManager;
        private LCategorias _lCategorias;
        private static DataPaginador<TCursos> models;
        private static IdentityError identityError;



        public CursosController(ApplicationDbContext _context,SignInManager<IdentityUser> _signInManager,
            IWebHostEnvironment environment)
        {
            context = _context;
            signInManager = _signInManager;
            _lCategorias = new LCategorias(context);
            _cursos = new LCursos(context, environment);
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

        [HttpPost]
        public String GetCurso (DataPaginador<TCursos> model)
        {
            if (model.Input.Nombre !=null && model.Input.Descripcion !=null && model.Input.CategoriaID>0)
            {
                if (model.Input.Horas.Equals(0))
                {
                    return "Ingrese la cantidad de horas del curso";

                }
                else
                {
                    if (model.Input.Costo.Equals(0.00M))
                    {
                        return "Ingrese el costo del curso";
                    }
                    else
                    {
                        var data = _cursos.RegistrarCursoAsyn(model);
                        return JsonConvert.SerializeObject(data.Result);
                    }
                }
            }
            else
            {
                return "Llene los campos requeridos";
            }
        }
    }
}
