using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++) 
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y == 0) {
                Console.WriteLine("divisao impossivel");
                } else {
                Console.WriteLine("{0:N1}", (X/Y));
                }
            }
        }
    }
}