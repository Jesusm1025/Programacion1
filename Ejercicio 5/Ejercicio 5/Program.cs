using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        /*Crear una clase llamada Producto, en el fichero "producto.cs". 
         *Esta clase deberá tener los atributos "nombre" y "descripcion", 
         *de tipo string. También deberá tener un método "agretarNombre", 
         *de tipo void y con un parámetro string, que permita cambiar el 
         *valor del nombre. Finalmente, también tendrá un método "productoDisponible",
         *que escribirá en pantalla "Producto, " seguido de su nombre 
         *y la descripción del producto. Crear también una clase llamada verProducto. 
         *Esta clase deberá contener sólo la función Main, que creará dos objetos de
         *tipo Producto, les asignará un nombre y les pedirá que lo muestre en pantalla.*/

        static void Main(string[] args)
        {
            AgretarNombre();
            Console.Read();
        }
        static void AgretarNombre(string nombre, string descripcion)
        {
            Producto producto;
            producto = new Producto();
            Console.WriteLine("Agregar nombre: ");
            producto.nombre = Console.ReadLine();
            Console.WriteLine("Agregar descripcion: ");
            producto.descripcion = Console.ReadLine();
        }
        static void ProductoDisponible()
        {
            Producto producto;
            producto = new Producto();
            Console.WriteLine("Producto, " + producto.nombre + " " + producto.descripcion);
        }
    }
}
