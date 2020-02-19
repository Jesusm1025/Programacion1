using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        /*Crear un metodo llamado "HolaEstudiante" con el valor predefinido (Su nombre) y
         llamarlo desde el Main muestre el saludo ("Hola, estudiante XX. 
         Bienvenido a programación I").*/
        static void Main(string[] args)
        {
            Console.Write(HolaEstudiante("Jesus"));
            Console.Read();
        }
        static string HolaEstudiante(string nombre)
        {
            string HolaEstudiante = "Hola, estudiantes " + nombre + ". Bienvenido a programacion I";
            return HolaEstudiante;
        }
    }
}
