using System;

namespace Desafio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            for (int i = 1; i <= n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                if (i > 2) {
                    n1 = n2;
                    n2 = n3;
                } else {
                    n2 = 1;
                }
            }
            Console.WriteLine("");
        }
    }
}