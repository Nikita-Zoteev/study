using System;

namespace Лабораторная_16._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во чисел: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] arr = new int[N];

            arr[0] = 1;

            Console.WriteLine($"1-e число = {arr[0]}", 10);

            for (int i = 1; i < N; i++)
            {
                arr[i] = arr[i - 1] + 2;

                Console.WriteLine($"{i+1} - e число = {arr[i]}", 10);
            }
        }
    }
}
