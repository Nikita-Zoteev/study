using System;
using System.Dynamic;

namespace Лабораяторная_13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, a, c = 0;

            Console.Write("Введите N: ");

            N = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                a = 2 * i - 1;

                c += a;

                Console.WriteLine($"{i}^2 = {c}");
            }
        }
    }
}
