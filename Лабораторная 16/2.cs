using System;

namespace Лабораторная_16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во чисел: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] arr = new int[N];

            Console.Write("Введите первый член прогрессии: ");

            arr[0] = Int32.Parse(Console.ReadLine());

            Console.Write("Введите знаменатель прогрессии: ");

            int D = Int32.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"1-e число = {arr[0]}");

            for (int i = 1; i < N; i++)
            {
                arr[i] = arr[i - 1] * D;

                Console.WriteLine($"{i+1}-e число = {arr[i]}");
            }
        }
    }
}
