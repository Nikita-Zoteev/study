using System;

namespace Лабораторная_16._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во чисел: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] arr = new int[N];

            Console.Write("Введите 1-е число: ");

            arr[0] = Int32.Parse(Console.ReadLine());

            Console.Write("Введите 2-е число: ");

            arr[1] = Int32.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"1-e число = {arr[0]}");

            Console.WriteLine($"2-e число = {arr[1]}");

            for (int i = 2; i < N; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];

                Console.WriteLine($"{i+1} - e число = {arr[i]}");
            }
        }
    }
}
