using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de Física");
            Console.WriteLine("Este programa permite calcular tiempo, velocidad y distancia a partir de dos entradas.");
            Console.WriteLine("");

            Console.WriteLine("Menú");
            Console.WriteLine("1. Tiempo");
            Console.WriteLine("2. Velocidad");
            Console.WriteLine("3. Distancia");

            Console.WriteLine("\n Selecciona una opción: \n");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el primer valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    double tiempo = valor1 / valor1;
                    Console.WriteLine("El tiempo es: " + tiempo + " segundos");
                    break;
                case 2:
                    double velocidad = valor1 / valor2;
                    Console.WriteLine("La velocidad es: " + velocidad + " m/s");
                    break;
                case 3:
                    double distancia = valor1 * valor2;
                    Console.WriteLine("La distancia es: " + distancia + " metros");
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            Console.ReadLine();
        }
    }
}
