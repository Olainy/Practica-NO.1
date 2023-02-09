using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solucionador de Ecuaciones Lineales de Primer Grado");
            Console.WriteLine("Este programa permite resolver ecuaciones lineales de primer grado de la forma ax + b = 0");
            Console.WriteLine("");

            Console.WriteLine("Introduce el valor de a:");
            decimal a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el valor de b:");
            decimal b = decimal.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("La ecuación no es lineal de primer grado");
                Console.ReadLine();
                return;
            }

            decimal x = -b / a;

            Console.WriteLine("La solución de la ecuación es x = " + x);

            Console.ReadLine();
        }
    }
}
