using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturando_2.Models
{
    public class FacturaProducto
    {
        public int FacturasId { get; set; }
        public int ProductoId { get; set; }
        public Factura FacturasP { get; set; }
        public Producto ProductoF { get; set; }
    }
}
