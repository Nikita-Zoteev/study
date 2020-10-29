using System;
using System.Runtime.InteropServices.ComTypes;

namespace Лабораторная_15._4
{
    class Program
    {

        static int Quarter(double x, double y)
        {
            if (x > 0 && y > 0)
                return 1;
            else if (x < 0 && y > 0)
                return 2;
            else if (x < 0 && y < 0)
                return 3;
            else return 4;
        }
        static void Main(string[] args)
        {
            Console.Write("Ввдеите координату X: ");

            double X = double.Parse(Console.ReadLine());

            Console.Write("Введите координату Y: ");

            double Y = double.Parse(Console.ReadLine());

            Console.WriteLine(Quarter(X,Y));
        }
    }
}
