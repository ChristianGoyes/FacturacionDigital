using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Facturando_2.Models
{

    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }

        public int IdClienteF { get; set; }

        public int IdFactutaF { get; set; }


        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Usuario> Usuarios { get; set; }

        public ICollection<FacturaCliente> FacturaClientes { get; set; }
        public ICollection<FacturaUsuario> FacturaUsuarios { get; set; }
        public ICollection<FacturaProducto> FacturaProductos { get; set; }


        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Valor total")]
        public float ValorTotal { get; set; }
    }



}
