using System;

namespace Лабораторная_18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массивов: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];

            Random randomize = new Random();

            for (int i = 0; i < N; i++)
            {
                A[i] = randomize.Next(9, 101);
                Console.WriteLine(A[i]);
            }

            Console.WriteLine("________________________");

            for (int i = 0; i < N; i++)
            {
                B[i] = randomize.Next(9, 101);
                Console.WriteLine(B[i]);
            }

            Console.WriteLine("________________________");

            int c;

            for (int i = 0; i < N; i++)
            {
                c = A[i];
                A[i] = B[i];
                B[i] = c;
            }

            Console.ReadKey();

            Console.Clear();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.WriteLine("________________________");

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(B[i]);
            }

            Console.WriteLine("________________________");
        }
    }
}
