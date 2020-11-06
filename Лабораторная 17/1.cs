using System;

namespace Лабораторная_17._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");

            int N = Int32.Parse(Console.ReadLine());

            Console.Write("Введите K: ");

            int K = Int32.Parse(Console.ReadLine());

            Console.Write("Введите L: ");

            int L = Int32.Parse(Console.ReadLine());

            int[] arr = new int[N];

            double sum = 0, result;

            Random randomize = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomize.Next(9, 101);
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("_____________________________________");

            for (int i = K; i <= L; i++)
            {
                sum += arr[i];
            }

            result = sum / (L - K + 1);

            Console.WriteLine($"Среденее арифметическое = {result}");
        }
    }
}
