using System;

namespace Лабораторная_15._5
{
    class Program
    {
        static double Fact2(int N)
        {
            if (N % 2 == 0)
            {
                if (N == 0)
                    return 0;
                if (N == 2)
                    return 2;
                return N * Fact2(N - 2);
            }
            else
            {
                if (N == 0)
                    return 0;
                if (N == 1)
                    return 1;
                return N * Fact2(N - 2);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");

            int N = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Fact2(N));
        }
    }
}
