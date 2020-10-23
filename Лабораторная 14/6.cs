using System;

namespace Лабораторная_14._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введит N: ");

            int N = Int32.Parse(Console.ReadLine());

            int K = 0; int a = 0, b = 1; int result = 0;

            while (N > result)
            {
                //Console.WriteLine($"{a} {b}");
                result = a + b;
                a = b;
                b = result;
                K++;
            }
            Console.WriteLine(K+2);
        }
    }
}
