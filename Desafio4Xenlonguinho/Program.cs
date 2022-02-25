using System;

namespace Desafio4Xenlonguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i < numero; i++)
            {
                int qtesferas = int.Parse(Console.ReadLine());
                if (qtesferas == 7) {
                    Console.WriteLine("5");
                } else if (qtesferas == 6) {
                    Console.WriteLine("4");
                } else if (qtesferas == 5) {
                    Console.WriteLine("3");
                } else if (qtesferas == 4) {
                    Console.WriteLine("2");
                } else if (qtesferas == 3) {
                    Console.WriteLine("2");
                } else if (qtesferas == 2) {
                    Console.WriteLine("1");
                } else {
                    Console.WriteLine("0");
                }
            }
        }
    }
}