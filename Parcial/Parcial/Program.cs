using Parcial.Entidades;
using Parcial.Negocio;

Usuario usuario = new Usuario();
ClsUsuario clsUsuario = new ClsUsuario();
Venta venta = new Venta();
ClsVenta clsVenta = new ClsVenta();

Console.WriteLine("Para acceder ingresa tu nombre de usuario: ");
usuario.Nombre = Console.ReadLine();

Console.WriteLine("Por favor ingresa tu contraseña: ");
usuario.Contra = Convert.ToInt32(Console.ReadLine());



if (clsUsuario.Acces(usuario) == true) 
{
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("Tu datos han sido verificados con exito, puedes proceder a realizar tus compra. ");
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("");
    Console.WriteLine("Ingresa el ID del Producto: ");
    venta.IdentificadorDeProducto = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine("Ingrese el nombre de el producto:");
    venta.NombreProducto = Console.ReadLine();
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine("Ingrese la descripcion de el producto: ");
    venta.DescripcionProducto = Console.ReadLine();
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine("Ingresa el precio de el producto: ");
    venta.PrecioProducto = float.Parse(Console.ReadLine());
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine("Ingresa la cantidad de el producto: ");
    venta.CantidadProducto = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine(clsVenta.Cobro(venta));

}
else
{
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
    Console.WriteLine("El usuario y contraseña ingresados son incorrectos");
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++");
}
