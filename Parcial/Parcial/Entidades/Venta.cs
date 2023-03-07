using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Entidades
{
    public class Venta
    {
        public int IdentificadorDeProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public float PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }
    }
}
