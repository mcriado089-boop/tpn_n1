using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PRECIOORIGINAL = 0;
            int DESCUENTO = 0;
            double PORCENTAJEDESCUENTO = 0;
            double Preciofinal = 0;

            Console.WriteLine("ingrse el precio del producto");
            PRECIOORIGINAL = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el porcentje del descuento");
            PORCENTAJEDESCUENTO= int.Parse(Console.ReadLine());
            // ACA CALCULO CUANTO SERA EL DESCUENTO EN PESOS
           DESCUENTO = PRECIOORIGINAL * (PORCENTAJEDESCUENTO/ 100);
            // CALCULA EL PRECIO FINAL QUE DEVO PAQGAR, AQPLICANDO EL DESCUENTO

            Preciofinal = PRECIOORIGINAL - DESCUENTO;
            Console.WriteLine($"PRECIO ORIGINAL:$ {PRECIOORIGINAL}");


        }
    }
}
