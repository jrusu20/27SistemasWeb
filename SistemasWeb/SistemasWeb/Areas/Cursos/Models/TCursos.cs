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
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripcion es obligatorio.")]
        public string Descripcion { get; set; }
        public byte Horas { get; set; }
         [Required(ErrorMessage = "El costo es obligatorio.")]
         [RegularExpression(@"^[0-9]+([.][0-9]+)?$",ErrorMessage ="Ingrese un numero en el Costo")]
        public decimal Costo { get; set; }
        public Boolean Estado { get; set; }
        [Required(ErrorMessage = "Favor elegir una Categoria.")]
        public int CategoriaID { get; set; }
        public byte[] Image { get; set; }
        public TCategoria Categoria { get; set; }
    }
}
