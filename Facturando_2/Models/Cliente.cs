using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Facturando_2.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Nombre nuevo cliente")]
        public string NombreCli { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Numero")]
        public string Numero { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        public ICollection<FacturaCliente> FacturaClientes { get; set; }

    }
}
