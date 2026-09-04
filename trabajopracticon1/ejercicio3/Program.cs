using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que solicite al usuario ingresar la distancia recorrida (en kilómetros) y el tiempo 
                         empleado(en horas).Calcula la velocidad promedio utilizando la fórmula: 
                                              Velocidad = distancia / tiempo.
                                    Muestra el resultado en pantalla*/

            double kilometros = 0;
            double horas = 0;
            double velocidad = 0;

            Console.WriteLine("ingrese la distancia recorrida");
            kilometros =double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el tiempo que empleo en el viaje ");
            horas =double.Parse(Console.ReadLine());

            velocidad =kilometros / horas;
            Console.WriteLine($"SU VELOCIDAD FUE DE{velocidad}");






        }
    }
}
