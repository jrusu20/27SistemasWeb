using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasWeb.Areas.Cursos.Controllers
{
    public class CursosController : Controller
    {
        public IActionResult Cursos()
        {
            return View();
        }
    }
}
