using System;
using System.Runtime.InteropServices;

namespace Лабораторная_18._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] A = new int[N];

            int min = int.MaxValue;
            int minN = 0;

            int max = int.MinValue;
            int maxN = 0;

            Random randomize = new Random();

            Console.Clear();

            for (int i = 0; i < N; i++)
            {
                A[i] = randomize.Next(9, 101);
                Console.WriteLine(A[i]);
                if (A[i] < min)
                {
                    min = A[i];
                    minN = i;
                }
                if (A[i] > max)
                {
                    max = A[i];
                    maxN = i;
                }
            }

            if (maxN > minN)
            {
                for (int i = minN+1; i < maxN; i++)
                {
                    A[i] = 0;
                }
            }
            else
            {
                for (int i = maxN + 1; i < minN; i++)
                {
                    A[i] = 0;
                }
            }

            Console.ReadKey();
            Console.Clear();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
