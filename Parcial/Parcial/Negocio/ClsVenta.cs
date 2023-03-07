using Parcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Negocio
{
    public class ClsVenta
    {

        public string Cobro(Venta venta)
        {
            float total = venta.PrecioProducto * venta.CantidadProducto;

            if (total > 50)
            {
                float descuento = total - 10;

                return $"+++++++++++++++++++++++++++++++++++++++++++\nPrecio Total: {total}$ \nPrecio con descuento aplicado: {descuento}$\n+++++++++++++++++++++++++++++++++++++++++++" +
                    $"\nID de Producto:  {venta.IdentificadorDeProducto}" +
                    $"\nNombre de Producto: {venta.NombreProducto}" +
                    $"\nDescripcion de el Producto: {venta.DescripcionProducto}" +
                    $"\nPrecio del Producto: {venta.PrecioProducto}" +
                    $"\nCantida de Producto adquirida: {venta.CantidadProducto}" +
                    $"\nTotal Cancelado: {descuento}$" +
                    $"\n+++++++++++++++++++++++++++++++++++++++++++";

            }
            else
            {
                return $"\n+++++++++++++++++++++++++++++++++++++++++++\nPrecio total: {total}$\n+++++++++++++++++++++++++++++++++++++++++++" +
                    $"\nID de Producto:  {venta.IdentificadorDeProducto}" +
                    $"\nNombre de Producto: {venta.NombreProducto}" +
                    $"\nDescripcion de el Producto: {venta.DescripcionProducto}" +
                    $"\nPrecio del Producto: {venta.PrecioProducto}" +
                    $"\nCantida de Producto adquirida: {venta.CantidadProducto}" +
                    $"\nTotal Cancelado: {total}$" +
                    $"\n+++++++++++++++++++++++++++++++++++++++++++";

            }
        }
    }
}
