using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNO._6
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
                Console.Write("Digite las cantidad: ");
                elementos = int.Parse(Console.ReadLine());

                if (elementos <= 0)
                {
                    Console.Write("\nDebe que ser mayor que 0\n");
                }

            } while (elementos <= 0);


            do
            {
                Console.Write("Digite el numero de elementos que conforman grupo: ");
                grupos = int.Parse(Console.ReadLine());


                if (grupos <= 0 || elementos < grupos)
                {
                    Console.Write("\nTiene que ser mayor que 0 y los grupos menor o igual a los elementos\n");
                }

            } while (grupos <= 0 || elementos < grupos);

            sinrepeticiones = Factorial(elementos);

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
