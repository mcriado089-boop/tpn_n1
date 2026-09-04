using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pedir que el usuaria ingre 2 medidas//
            //largo , ancho y de pór rsultado el perimetro del terreno rectangular//

            double largo = 0;
            double ancho = 0;
            double  perimetro = 0;

            Console.WriteLine("escriba el largo del terreno");
            largo= double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el ancho del terreno");
            ancho= double.Parse(Console.ReadLine());

            perimetro= largo + ancho;
            Console.WriteLine($"su perimetro total es :{perimetro}");

        }
    }
}
