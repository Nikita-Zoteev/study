using System;

namespace Лабораторная_18._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");

            int N = Int32.Parse(Console.ReadLine());

            Random randomize = new Random();

            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = randomize.Next(9, 101);

                Console.WriteLine(A[i]);
            }

            Console.WriteLine("__________________");

            int neChet = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 != 0)
                    neChet = A[i];
            }

            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 != 0)
                    A[i] += neChet;

                Console.WriteLine(A[i]);
            }
        }
    }
}