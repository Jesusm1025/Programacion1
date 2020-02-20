using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    //Marca, Modelo, Año, Color y un estado(encendido/apagado).
    public class Vehiculo
    {
        public Vehiculo() 
        {
            Marca = "";
            Modelo = "";
            año = 0;
            Color = "";
            encendido = false;

        }
        public string Marca;
        public string Modelo;
        public int año;
        public string Color;
        public Boolean encendido;
    }
}
