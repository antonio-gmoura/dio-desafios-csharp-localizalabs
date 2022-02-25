using System;

namespace Desafio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int t);
            int p = 0;
            for (int i = 0; i < 1000; i++)
            {
                p ++;
                if (p > t) {
                    p = 1;
                }
                Console.WriteLine("N[{0}] = {1}", i, p-1);
            }
        }
    }
}