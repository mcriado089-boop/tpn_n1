using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CREAR UN PROGRAMAEscribe un programa que solicite al usuario ingresar el precio de un producto y la cantidad que desea 
            comprar.Calcula el costo total de la compra y muestra el resultado en pantalla.*/


            /* el programa lo hize para quea libre producto y el usuario ponga cualquier producto */



            double precio = 0;

            string producto = "0";

            int cantidad = 0;

            double total = 0;

            

            Console.WriteLine("ELIJA UN PRODUCTO");
            producto = Console.ReadLine();

            Console.WriteLine("precio del producto");
             precio = double.Parse(Console.ReadLine());

            Console.WriteLine("elija cantidad");
           cantidad =int.Parse(Console.ReadLine());

            total = precio * cantidad;
            Console.WriteLine($"su tutal es:${total}");


        }
    }
}
