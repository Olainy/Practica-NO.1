using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculador de Calificación Promedio");
            Console.WriteLine("Este programa permite calcular la calificación promedio y determinar el literal correspondiente.");
            Console.WriteLine("");

            Console.WriteLine("Introduce el número de calificaciones a procesar:");
            int calificaciones = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i < calificaciones; i++)
            {
                Console.WriteLine("Introduce la calificación " + (i + 1) + ":");
                int calificacion = int.Parse(Console.ReadLine());
                sum += calificacion;
            }

            int promedio = sum / calificaciones;

            Console.WriteLine("La calificación promedio es: " + promedio);

            string literal;
            if (promedio >= 90 && promedio <= 100)
            {
                literal = "A";
            }
            else if (promedio >= 80 && promedio <= 89)
            {
                literal = "B";
            }
            else if (promedio >= 70 && promedio <= 79)
            {
                literal = "C";
            }
            else if (promedio >= 0 && promedio <= 69)
            {
                literal = "F";
            }
            else
            {
                literal = "Calificación inválida";
            }

            Console.WriteLine("El literal correspondiente es: " + literal);

            Console.ReadLine();
        }
    }
}