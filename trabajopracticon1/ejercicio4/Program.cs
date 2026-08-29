using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que solicite al usuario ingresar los kilómetros recorridos y los litros de combustible 
               utilizados. Calcula el consumo promedio del vehículo.  */

            int kilometros = 0;
           
            double litros = 0;

            string veiculo = "0";

            double consumo  = 0;




            Console.WriteLine("ingrese su veiculo ");
            veiculo = Console.ReadLine();

            Console.WriteLine("cantidad de kilometros ");
            kilometros = int.Parse(Console.ReadLine());

            Console.WriteLine("cantidad de litros usados");
            litros = int.Parse(Console.ReadLine());

            consumo = kilometros / litros;
            Console.WriteLine($"su consumo  por litro es de ${consumo }");


        }
    }
}
