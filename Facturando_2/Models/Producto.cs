using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Facturando_2.Models
{
    public class Producto
    {
        [Key]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required]
        [Display(Name = "Valor")]
        public int valor { get; set; }

        public ICollection<FacturaProducto> FacturaProductos { get; set; }


    }
}
