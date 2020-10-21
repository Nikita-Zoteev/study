using System;
using System.Threading;

namespace Лабораторная_13._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, N, Sum = 1;

            Console.Write("Введите A: ");

            A = Int32.Parse(Console.ReadLine());

            Console.Write("Введите N: ");

            N = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Sum += Convert.ToInt32(Math.Pow(A, i));
            }

            Console.WriteLine(Sum);
        }
    }
}
