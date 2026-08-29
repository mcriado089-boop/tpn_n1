using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadhora = 0;
            double preciodehora = 0;

            double resultado =0;

            Console.WriteLine("ingresa la cantidad de horas trabajadas");
            cantidadhora = int.Parse ( Console. ReadLine());

            Console.WriteLine("ingrese el precio de la hora");
            preciodehora= double.Parse(Console.ReadLine());

            resultado = cantidadhora * preciodehora;

            Console.WriteLine($" el total a pagar es:${resultado.ToString("F2")}");
            //FALTA TERMINAR EL 

        }
    }
}
