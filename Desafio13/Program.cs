using System;

namespace Desafio13
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int c);
            int soma;
            for (int i = 0; i < c; i++)
            {
                int.TryParse(Console.ReadLine(), out int n);
                soma = 0;
                for (int x = 1; x < n; x++) {
                    if (n % x == 0) {
                        soma += x;
                    }
                }
                string r = (soma == n) ? "eh" : "nao eh";
                Console.WriteLine("{0} {1} perfeito", n, r);
            }
        }
    }
}