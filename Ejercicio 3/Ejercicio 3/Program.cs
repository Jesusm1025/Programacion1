using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        //Crear un metodo con un programa que genere un número
        //al azar entre 1 y 100. El usuario tendrá 6 oportunidades para acertarlo. 
        //Llamarlo desde el Main.
        static void Main(string[] args)
        {
            NumeroAleatoreo();
            Console.ReadLine();
        }
        static void NumeroAleatoreo()
        {
            int oportunidades = 6;
            int num, entrada, i, adivinado;

            // obtenemos un numero aleatorio entre 1 y 100
            Random ran = new Random();
            num = ran.Next(1, 101);
            i = 1; adivinado = 0;

            do
            {
                Console.Write("Adivina un numero entre 1 y 100: ");
                entrada = int.Parse(Console.ReadLine());
                if ((entrada == num))
                {
                    Console.WriteLine("Has adivinado el numero");
                    adivinado = 1;
                }
                else
                {
                    if ((entrada > num))
                    {
                        Console.WriteLine("Estas alto");
                    }
                    else
                    {
                        Console.WriteLine("Estas bajo");
                    }
                }
                i++;
            } while (((i <= oportunidades) & (adivinado == 0)));
            if ((adivinado == 0))
            {
                Console.Write("Has agotado los intentos... El numero fue: " + num);
            }
        }

    }
}
