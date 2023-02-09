using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=1;
            int c=1;

            Console.WriteLine(" *** PROGRAMA QUE DESPLIEGUE LA SERIE FIBONACCI DE UN NUMERO *** ");

            Console.WriteLine(" Por favor digite un numero: ");
            int n = int.Parse(Console.ReadLine());

            while (c <= n)
            {
                if (c % 2 == 1)
                {
                    Console.Write(a + ",");
                    a = a + b;

                }
                else 
                {
                    Console.Write(b + ",");
                    b = b + a; 
                }
                c = c + 1;
            }
            Console.ReadKey();
        }
    }
}
