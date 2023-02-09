using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desglosador de Billetes y Monedas");
            Console.WriteLine("Este programa permite desglosar una cantidad de dinero en billetes y monedas.");
            Console.WriteLine("");

            Console.WriteLine("Introduce la cantidad de dinero:");
            decimal amount = decimal.Parse(Console.ReadLine());

            int[] bills = { 100, 50, 20, 10, 5, 2, 1 };
            decimal[] coins = { 0.50M, 0.20M, 0.10M, 0.05M, 0.02M, 0.01M };

            Console.WriteLine("Billetes:");
            for (int i = 0; i < bills.Length; i++)
            {
                int numberOfBills = (int)(amount / bills[i]);
                if (numberOfBills > 0)
                {
                    Console.WriteLine(numberOfBills + " x " + bills[i] + " €");
                    amount -= numberOfBills * bills[i];
                }
            }

            Console.WriteLine("Monedas:");
            for (int i = 0; i < coins.Length; i++)
            {
                int numberOfCoins = (int)(amount / coins[i]);
                if (numberOfCoins > 0)
                {
                    Console.WriteLine(numberOfCoins + " x " + coins[i] + " €");
                    amount -= numberOfCoins * coins[i];
                }
            }

            Console.ReadLine();
        }
    }
}