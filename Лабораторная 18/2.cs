using System;

namespace Лаюораторная_18._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] A = new int[N];

            double[] B = new double[N];

            Random randomize = new Random();

            for (int i = 0; i < N; i++)
            {
                A[i] = randomize.Next(9, 101);
                Console.WriteLine(A[i]);
            }

            Console.WriteLine("_________________");


            for (int i = 0; i < N; i++)
            {
                double sum = 0;

                for (int j = 0; j <= i ; j++)
                {
                    sum += A[j];
                }

                B[i] = sum / (i+1);
                Console.WriteLine(B[i]);
            }
        }
    }
}
