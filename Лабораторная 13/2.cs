using System;

namespace Лабораторная_13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b; int N;

            a = 1.1;
            b = 1.2;

            Console.Write("Введите N: ");

            N = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {
                a *= b;
                b += 0.1;

            }
            Console.WriteLine(Math.Round(a,N));
        }
    }
}
