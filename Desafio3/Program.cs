using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi, raio, volume;
            pi = 3.14159;
            raio = double.Parse(Console.ReadLine());
            volume = (4.0/3.0) * pi * Math.Pow(raio, 3);
            string mens = $"VOLUME = {volume:N3}";
            Console.WriteLine(mens.Replace(",",""));
            //Console.WriteLine("VOLUME = {0:N3}", volume);
        }
    }
}