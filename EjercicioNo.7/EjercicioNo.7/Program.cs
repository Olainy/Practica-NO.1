using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elementos;
            int grupos;
            int sinrepeticiones = 0;
            int conrepeticiones;

            do
            {
                Console.Write("Ingrese las cantidad de elementos: ");
                elementos = int.Parse(Console.ReadLine());

                if (elementos <= 0)
                {
                    Console.Write("La cantidad tienen que ser mayores que 0\n");
                }

            } while (elementos <= 0);


            do
            {
                Console.Write("Ingrese el numero de elementos que conforman grupo: ");
                grupos = int.Parse(Console.ReadLine());


                if (grupos <= 0 || elementos < grupos)
                {
                    Console.Write("El numero tienen que ser mayores que 0 y los grupos menor o igual a los elementos\n");
                }

            } while (grupos <= 0 || elementos < grupos);

            sinr = Factorial(elementos) / (Factorial(elementos - grupos) * Factorial(grupos));

            conr = Factorial(elementos + grupos - 1) / (Factorial(grupos) * Factorial(elementos - 1));

            Console.WriteLine("Con repeticiones: " + conrepeticiones);
            Console.WriteLine("Sin repeticiones: " + sinrepeticiones);

            Console.ReadKey();
        }

        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }
}
