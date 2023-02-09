using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operaciones con fracciones,las operaciones a realizar son sumas, restas, multiplicacion, division

            int opcion;
            int numerador1 = 0;
            int numerador2 = 0;
            int denominador1 = 0;
            int denominador2 = 0;
            string result = "";

            do
            {
                Console.WriteLine("**Por favor Digite el primer numerador : ");
                numerador1 = int.Parse(Console.ReadLine());


                if (numerador1 < 0)
                {
                    Console.WriteLine("\nError: Número negativo...\n");
                }

            } while (numerador1 < 0);

            do
            {
                Console.WriteLine("***Por favor Digite el primer denominador: ");
                denominador1 = int.Parse(Console.ReadLine());


                if (denominador1 < 0)
                {
                    Console.WriteLine("\nError: Número negativo...\n");
                }

            } while (denominador1 < 0);

            do
            {
                Console.WriteLine("***Por favor Digite el segundo numerador 2: ");
                numerador2 = int.Parse(Console.ReadLine());


                if (numerador2 < 0)
                {
                    Console.WriteLine("\nError: Número negativo...\n");
                }

            } while (numerador2 < 0);

            do
            {
                Console.WriteLine("Por favor Digite el segundo denominador 2: ");
                denominador2 = int.Parse(Console.ReadLine());


                if (denominador2 < 0)
                {
                    Console.WriteLine("\nError: Número negativo...\n");
                }

            } while (denominador2 < 0);


            Console.WriteLine("***Operaciones con fraciones, Por Favor selecione una opcion");
            Console.WriteLine("1 - Suma");
            Console.WriteLine("2 - Resta");
            Console.WriteLine("3 - Multiplicación");
            Console.WriteLine("4 - Division");

            do
            {

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        if (denominador1 == denominador2)
                {
                    result = $"{numerador1 + numerador2}/{denominador2}";
                }
                else
                {
                    result = $"{((numerador1 * denominador2) + (numerador2 * denominador1))}/{denominador2 * denominador1}";
                }

                break;

                case 2:
                        if (denominador1 == denominador2)
                {
                    result = $"{numerador1 - numerador2}/{denominador2}";
                }
                else
                {
                    result = $"{((numerador1 * denominador2) - (numerador2 * denominador1))}/{denominador2 * denominador1}";
                }

                break;

                case 3:

                          result = $"{numerador1 * numerador2}/{denominador2 * denominador1}";

                break;
                case 4:

                        result = $"{(numerador1 * denominador2)}/{(numerador2 * denominador1)}";
                break;

            }

                if (opcion < 1 || opcion > 6)
            {
                Console.WriteLine("\nError: No existe esa opción...\n");
            }
            else
            {
                Console.WriteLine($"\nResultado: {result}");
            }

        } while (opcion< 1 || opcion> 6);

            Console.ReadKey();
        }
    }
}
