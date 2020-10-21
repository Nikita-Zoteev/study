using System;

namespace Лабораторная_13._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, sum = 1; int N;

            Console.Write("Введите A: ");

            A = double.Parse(Console.ReadLine());

            Console.Write("Введите N: ");

            N = Int32.Parse(Console.ReadLine());

            A = -A;

            for (int i = 1; i <= N; i++)
            {
                sum += Math.Pow(A, i);                
            }


            Console.WriteLine(sum);
        }
    }
}
