using System;

namespace Лабораторная_16._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите {i+1}-е число: ");

                A[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Clear();

            int j = 0;

            while (j < N)
            {
                if (j % 2 == 0)
                    Console.WriteLine(A[j]);
                j++;
            }
            j = N-1;
            while ( j >= 0)
            {
                if (j % 2 != 0)
                    Console.WriteLine(A[j]);
                j--;
            }
        }
    }
}
