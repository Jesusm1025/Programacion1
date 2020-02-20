using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        //Crear una clase llamada vehiculo, con los objetos (Marca, Modelo, 
        //Año, Color y un estado(encendido/apagado). Podremos encenderlo o 
        //apagarlo, al ejecutar nos mostrara los datos del vehiculo y el estado, 
        //si esta encendido o apagado.
        static void Main(string[] args)
        {
            string respuesta;
            Vehiculo vehiculo;

            vehiculo = new Vehiculo();
            Console.WriteLine("Intodruza la marca del vehiculo: ");
            vehiculo.Marca = Console.ReadLine();
            Console.WriteLine("Introduzca el modelo del vehiculo: ");
            vehiculo.Modelo = Console.ReadLine();
            Console.WriteLine("Introduzca el año del vehiculo: ");
            vehiculo.año = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el color del vehiculo: ");
            vehiculo.Color = Console.ReadLine();
            Console.WriteLine("El estado del vehiculo es: " + Encender());
            Console.WriteLine("Desea encender el vehiculo o apagar?");
            respuesta = Console.ReadLine();
            if(respuesta == "encender")
            {
                Prender();
                Console.WriteLine("El estado del vehiculo es: " + Encender());
            }
            else
            {
                Apagar();
                Console.WriteLine("El estado del vehiculo es: " + Encender());
            }
            Console.Read();
        }
        static string Encender()
        {
            Vehiculo vehiculo;
            vehiculo = new Vehiculo();
            string estado = "";
            if(vehiculo.encendido == true)
            {
                estado = "Encendido";
            }
            else
            {
                estado = "Apagado";
            }
            return estado;
        }
        static void Prender()
        {
            Vehiculo vehiculo;
            vehiculo = new Vehiculo();
            vehiculo.encendido = true;
        }
        static void Apagar()
        {
            Vehiculo vehiculo;
            vehiculo = new Vehiculo();
            vehiculo.encendido = false;
        }
    }
}
