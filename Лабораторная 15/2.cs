using System;

namespace Лабораторная_15._2
{
    class Program
    {
        static int SignX(double X)
        {
            if (X < 0) return -1;
            else if (X == 0) return 0;
            else return 1;

        }
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");

            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите B:");

            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(SignX(a) + SignX(b));
        }
    }
}
