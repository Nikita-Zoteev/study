using System;

namespace Лабораторная_17._5
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

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j= i+1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine($"{i} {j}");
                }
            }
        }
    }
}
