using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioNo._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int area;
            int numero;
            int radio;

            Console.WriteLine("\n Elija la figura geometrica a la cual le desea calcular el area: \n");
            Console.WriteLine("1.- Cuadrado ");
            Console.WriteLine("2.- Circulo");
            Console.WriteLine("3.- Triangulo");
            Console.WriteLine("4.- Pentagono");
            Console.WriteLine("5.- Hexagono");

            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero) {
                
                case 1:
                    Console.WriteLine("Digite la base o el lado: ");

                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite la altura o el lado: ");

                    a = Convert.ToInt32(Console.ReadLine());

                    area = b * a;
                    Console.WriteLine(" El area del cuadrado es: " + area);

                    Console.ReadLine();
                    break;

                case 2:
                    Console.Write("Ingrese el radio del circulo: ");
                    radio = Int32.Parse(Console.ReadLine());

                    area = (int)(radio * radio * 3.1415);

                    Console.WriteLine(" El area del circulo es: " + area);

                    Console.ReadLine();
                    break;  

                case 3:
                    Console.Write("Ingrese la base del rectangulo: ");
                    b = Int32.Parse(Console.ReadLine());

                    Console.Write("Ingrese la altura del rectangulo: ");
                    a = Int32.Parse(Console.ReadLine());

                    area = (b * a) / 2;

                    Console.WriteLine(" El area del triangulo es: " + area);

                    Console.ReadLine();
                    break;

                case 4:
                    Console.Write("Ingrese el perimetro del pentagono: ");
                    b = Int32.Parse(Console.ReadLine());

                    Console.Write("Ingrese la apotema del pentagono: ");
                    a = Int32.Parse(Console.ReadLine());

                    area = (b * a) / 2;

                    Console.WriteLine(" El area del pentagono es: " + area);

                    Console.ReadLine();
                    break;

                case 5:
                    Console.Write("Ingrese el perimetro del hexagono: ");
                    b = Int32.Parse(Console.ReadLine());

                    Console.Write("Ingrese la apotema del hexagono: ");
                    a = Int32.Parse(Console.ReadLine());

                    //Realiza la operacion
                    area = (b * a) / 2;

                    Console.WriteLine(" El area del hexagonono es: " + area);

                    Console.ReadLine();
                    break;

            }
        }
        }
}
