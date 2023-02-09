using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double angulo;
            double anguloRadianes;
            double result = 0;

            Console.Write("Calculo de Funciones Trigonometricas, Por favor selecione una opcion: ");

            Console.WriteLine("1 - seno");
            Console.WriteLine("2 - coseno");
            Console.WriteLine("3 - secante");
            Console.WriteLine("4 - cosecante");
            Console.WriteLine("5 - tangente");
            Console.WriteLine("6 - cotangente");

            do
            {
                opcion = int.Parse(Console.ReadLine());


                do
                {
                    Console.Write("Por favor Digite el angulo: ");
                    angulo = double.Parse(Console.ReadLine());


                    if (angulo < 0)
                    {
                        Console.Write("\nError: Número negativo...\n");
                    }

                } while (angulo < 0);

                anguloRadianes = angulo * Math.PI / 180.0;

                switch (opcion)
                {
                    case 1:

                        result = Math.Sin(anguloRadianes);
                        break;

                    case 2:

                        result = Math.Cos(anguloRadianes);
                        break;

                    case 3:
                        ;
                        result = 1 / Math.Cos(anguloRadianes);
                        break;
                    case 4:

                        result = 1 / Math.Tan(anguloRadianes);
                        break;
                    case 5:

                        result = Math.Tan(anguloRadianes);
                        break;
                    case 6:

                        result = 2 * Math.Atan(1) - Math.Atan(anguloRadianes);
                        break;
                }

                if (opcion < 1 || opcion > 6)
                {
                    Console.Write("\nError: No existe esa opción...\n");
                }
                else
                {
                    Console.Write($"\nResultado: {result}");
                }

            } while (opcion < 1 || opcion > 6);

            Console.ReadKey();
        }
    }
}
