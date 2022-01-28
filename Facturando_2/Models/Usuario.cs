using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facturando_2.Models
{
    public class Usuario
    {
        [Key]

        public int IdFacturador { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string NombreFac { get; set; }

        [Required]
        [Display(Name = "Edad")]
        public int Edad { get; set; }
        public ICollection<FacturaUsuario> FacturaUsuarios { get; set; }

    }
}
