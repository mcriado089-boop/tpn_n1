using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
           


            Console.WriteLine("ingrese su edad");
            edad =int.Parse(Console.ReadLine());

            int diasvividos = edad * 365;
           

            Console.WriteLine($"usted vivio en dias aproximado {diasvividos}");

        }
    }
}
