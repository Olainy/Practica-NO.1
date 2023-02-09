using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine(" *** PROGRAMA QUE CALCULA EL FACTORIAL DE UN NUMERO ***\n");

            do
            {
                Console.Write("Por favor introduzca un número: ");
                numero = int.Parse(Console.ReadLine());
                verificar(numero);

            } while (numero < 0);

            factorial(numero);

            Console.ReadKey();
        }
        static void verificar(int n)
        {
            if (n < 0)
            {
                Console.Write("\n No existe el factorial de un número negativo.\n");
            }
        }
        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
        }
    }
}