using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles ="Admin")]
        public IActionResult Cursos(int id,String Search, int Registros)
        {
            if (signInManager.IsSignedIn(User))
            {
                Object[] objects = new Object[3];
                var data = _cursos.getTCursos(Search);

                if (0<data.Count)
                {
                    var url = Request.Scheme + "://" + Request.Host.Value;
                    objects = new LPaginador<TCursos>().paginador(data, id, Registros,
                        "Cursos", "Cursos", "Cursos", url);

                }
                else
                {
                    objects[0] = "No hay datos que mostrar";
                    objects[1] = "No hay datos que mostrar";
                    objects[2] = new List<TCursos>();
                }

                models = new DataPaginador<TCursos>
                {
                   List=(List<TCursos>)objects[2],
                   Pagi_info=(String)objects[0],
                   Pagi_navegacion=(String)objects[1],
                   Categorias=_lCategorias.getTCategorias(),
                    Input=new TCursos()
                };
                if (identityError!=null)
                {
                    models.Pagi_info = identityError.Description;
                    identityError = null;

                }
                return View(models);
            }
            else
            {
                return Redirect("/Home/Index");
            }
       
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
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
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult UpdateEstado (int id)
        {
            identityError = _cursos.UpdateEstado(id);
            return Redirect("/Cursos/Cursos?area=Cursos");
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public String EliminarCurso(int CursoID)
        {
            identityError = _cursos.DeleteCurso(CursoID);
            return JsonConvert.SerializeObject(identityError);
        }
    }
}
