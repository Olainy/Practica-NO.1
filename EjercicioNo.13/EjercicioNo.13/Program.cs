using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora de Salario Neto");
            Console.WriteLine("Este programa permite calcular el salario neto a partir del salario bruto, considerando las deducciones por AFP y Seguro de Salud.");
            Console.WriteLine("");

            Console.WriteLine("Introduce la cantidad de horas trabajadas:");
            int HorasTrabajo = int.Parse(Console.ReadLine());

            decimal Hora = 10;
            decimal SalarioBase = HorasTrabajo * Hora;
            decimal TiempoExtra = 0;

            if (HorasTrabajo > 44)
            {
                TiempoExtra = (HorasTrabajo - 44) * (Hora * 0.3M);
            }

            decimal SalarioBruto = SalarioBase + TiempoExtra;
            decimal afp = SalarioBruto * 0.0725M;
            decimal SeguroSalud = SalarioBruto * 0.03M;
            decimal SalarioNeto = SalarioBruto - afp - SeguroSalud;

            Console.WriteLine("Salario Bruto: " + SalarioBruto);
            Console.WriteLine("AFP: " + afp);
            Console.WriteLine("Seguro de Salud: " + SeguroSalud);
            Console.WriteLine("Salario Neto: " + SalarioNeto);

            Console.ReadLine(); 


        }
    }
}
