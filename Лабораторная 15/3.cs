using System;
using System.Data;

namespace Лабораторная_15._3
{
    class Program
    {
        static double RingS(double R1, double R2)
        {
            double PI = 3.14;

            return Math.Pow(R1, 2) * PI - Math.Pow(R2, 2) * PI;
        }
        static void Main(string[] args)
        {
            double[] arr1 = new double[3];

            double[] arr2 = new double[3];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write($"Введите диаметр {i+1}-ого большой окружности: ");

                arr1[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"Введите диаметр {i + 1}-ого меньшей окружности: ");

                arr2[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(RingS(arr1[i], arr2[i]));
            }
        }
    }
}
