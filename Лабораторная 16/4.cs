using System;

namespace Лабораторная_16._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввежите кол-во чисел: ");

            int N = Int32.Parse(Console.ReadLine()); int t;

            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Введите {i+1} - e число: ");

                A[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 1; i < N-1; i++)
            {

                if (i % 2 == 1)
                {
                    t = A[i];
                    A[i] = A[N - 1];
                    for (int j = N-1; j > i; j--)
                    {
                        A[j] = A[j - 1];
                    }
                    A[i + 1] = t;
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{i+1} - e число {A[i]}");
            }
        }
    }
}
#region Вычисления
/*  1 2 3 4 5
    1 5 2 4 3
indexe
    0 1 2 3 4*/
/*
 * 1 2 3 4 5
 * 1 5 3 4 2
 * 1 5 2 4 3
 * 
 * ______________
 * indexы`
 * 0 1 2 3 4 5 6
 * _____________
 * 1 2 3 4 5 6 7
 * 1 7 3 4 5 6 2
 * 1 7 2 4 5 6 3
 * 1 7 2 6 5 4 3
 * 1 7 2 6 3 4 5
 * 1 7 2 6 3 5 4
 */
#endregion