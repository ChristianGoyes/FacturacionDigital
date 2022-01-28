using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Facturando_2.Models
{
    public class FacturaUsuario
    {
        public int FacturasId { get; set; }
        public int UsuariosId { get; set; }
        public Factura FacturasU { get; set; }
        public Usuario UsuarioF { get; set; }
    }
}
