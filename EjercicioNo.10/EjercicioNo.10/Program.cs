using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cambio de temperatura");
            Console.WriteLine("1. Farenheit a Celsius");
            Console.WriteLine("2. Celsius a Farenheit");
            Console.WriteLine("3. Farenheit a Kelvin");
            Console.WriteLine("4. Kelvin a Farenheit");
            Console.WriteLine("5. Celsius a Kelvin");
            Console.WriteLine("6. Kelvin a Celsius");

            Console.Write("Seleccione una opcion: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese la temperatura en Farenheit: ");
                double farenheit = double.Parse(Console.ReadLine());
                double celsius = (farenheit - 32) * 5 / 9;
                Console.WriteLine("La temperatura en Celsius es: " + celsius);
            }
            else if (opcion == 2)
            {
                Console.Write("Ingrese la temperatura en Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double farenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine("La temperatura en Farenheit es: " + farenheit);
            }
            else if (opcion == 3)
            {
                Console.Write("Ingrese la temperatura en Farenheit: ");
                double farenheit = double.Parse(Console.ReadLine());
                double kelvin = (farenheit - 32) * 5 / 9 + 273.15;
                Console.WriteLine("La temperatura en Kelvin es: " + kelvin);
            }
            else if (opcion == 4)
            {
                Console.Write("Ingrese la temperatura en Kelvin: ");
                double kelvin = double.Parse(Console.ReadLine());
                double farenheit = (kelvin - 273.15) * 9 / 5 + 32;
                Console.WriteLine("La temperatura en Farenheit es: " + farenheit);
            }
            else if (opcion == 5)
            {
                Console.Write("Ingrese la temperatura en Celsius: ");
                double celsius = double.Parse(Console.ReadLine());
                double kelvin = celsius + 273.15;
                Console.WriteLine("La temperatura en Kelvin es: " + kelvin);
            }
            else if (opcion == 6)
            {
                Console.Write("Ingrese la temperatura en Kelvin: ");
                double kelvin = double.Parse(Console.ReadLine());
                double celsius = kelvin - 273.15;
                Console.WriteLine("La temperatura en Celsius es: " + celsius);
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        }
    }
}



