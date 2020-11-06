using System;
using System.ComponentModel.DataAnnotations;

namespace Лабораторная_17._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ramdomize = new Random();

            Console.Write("Введите длину массива: ");

            int N = Int32.Parse(Console.ReadLine());

            int[] A = new int[N];

            int min = int.MaxValue;
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = ramdomize.Next(9, 101);
                Console.WriteLine(A[i]);
            }

            Console.WriteLine("________________________________");

            for (int i = 0; i < A.Length/2; i++)
            {
                if (A[i * 2] < min)
                    min = A[i * 2];
            }
            Console.WriteLine(min);
        }
    }
}
