using System;

namespace Лабораторная_17._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] arr = new int[N];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Clear();

            int k = 1;

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[1] - arr[0]) == Math.Abs(arr[i] - arr[i + 1]))
                {
                    k += 1;
                }
                else
                {
                    break;
                }
            }

            if (k == N -1)
                Console.WriteLine(arr[1]-arr[0]);
            else
                Console.WriteLine(0);
        }
    }
}
