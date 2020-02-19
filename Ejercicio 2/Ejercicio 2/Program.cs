using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        //Crear un metodo que recorra los numeros del 1-50 usando un bucle for. 
        //Llamar el metodo desde el Main.
        static void Main(string[] args)
        {
            Recorrer(1, 50);
            Console.Read();
        }
        static void Recorrer(int desde, int hasta)
        {
            for(int i = desde; i <= hasta; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
