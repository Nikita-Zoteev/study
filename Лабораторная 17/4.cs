using System;

namespace Лабораторная_17._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] arr = new int[N];

            Random randomize = new Random();

            int localMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomize.Next(9, 101);

                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("________________________________");

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                    localMax = arr[i];
            }
            Console.WriteLine(localMax);
        }
    }
}
