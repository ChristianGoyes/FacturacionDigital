using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturando_2.Models
{
    public class FacturaCliente
    {
        public int FacturasId { get; set; }
        public int ClientesId { get; set; }
        public Factura FacturasC { get; set; }
        public Cliente ClientesF { get; set; }
    }
}
