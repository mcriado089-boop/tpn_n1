using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
               int juego1 ,juego2, juego3 = 0;
            


            Console.WriteLine("ingrese los puntos de su juego 1");
            juego1=int.Parse(Console.ReadLine());


            Console.WriteLine("ingrese los puntos de su juego 2");
            juego2=int.Parse(Console.ReadLine());



            Console.WriteLine("ingrese los puntos de su juego 3");
            juego3=int.Parse(Console.ReadLine());

            double puntajetotal =juego1+juego2+juego3;

            Console.WriteLine($"SU PUNTAJE TOTAL ES DE :{puntajetotal}");
        }
    }
}
