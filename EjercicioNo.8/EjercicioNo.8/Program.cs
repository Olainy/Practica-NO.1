using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x1, x2;
            int opcion;


            do
            {
                Console.WriteLine("Valor de A: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Valor de B: ");
                b = double.Parse(Console.ReadLine());

                Console.WriteLine("Valor de C: ");
                c = double.Parse(Console.ReadLine());

                x1 = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);
                x2 = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

                Console.WriteLine("El valor de x1 es " + x1);
                Console.WriteLine("El valor de x2 es " + x2);


                    Console.WriteLine(" ");
                    Console.WriteLine("Que deseas: ");
                    Console.WriteLine("1.- Salir");
                    Console.WriteLine("2.- Continuar");

                    opcion = Convert.ToInt32(Console.ReadLine());

            } while(opcion != 1);

            if (opcion == 1)
            {
                Console.WriteLine("SALIENDO DEL PROGRAMA");

            }

            Console.ReadKey();
            

        }
    }
}