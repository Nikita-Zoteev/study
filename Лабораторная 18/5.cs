using System;

namespace Лабораторная_18._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] A = new int[N];

            for (int i = 0; i < N; i++)
            {
                A[i] = Int32.Parse(Console.ReadLine());

            }

            int j = 1, c = 0;
            int temp;

            Console.ReadKey();
            Console.Clear();

            while (A[c] > A[j])
            {
                temp = A[c];
                A[c] = A[j];
                A[j] = temp;
                c = j;
                j++;
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
