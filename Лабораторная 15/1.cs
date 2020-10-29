using System;
using System.Diagnostics;

namespace Лабораторная_15._1
{
    class Program
    {
        static double PowerA3(double A)
        {
            double B;

            B = Math.Pow(A, 3);

            return B;
        }
        static void Main(string[] args)
        {
            double[] arr = new double[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(PowerA3(arr[i]));
            }
        }
    }
}
