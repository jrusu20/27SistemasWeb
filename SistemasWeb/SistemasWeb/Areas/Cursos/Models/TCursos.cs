using SistemasWeb.Areas.Categorias.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemasWeb.Areas.Cursos.Models
{
    public class TCursos
    {
        [Key]
        public int CursoID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Horas { get; set; }
        public decimal Costo { get; set; }
        public Boolean Estado { get; set; }
        public int CategoriaID { get; set; }
        public byte[] Image { get; set; }
        public TCategoria Categoria { get; set; }
    }
}
