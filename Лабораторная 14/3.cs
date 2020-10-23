using System;

namespace Лабораторная_14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N: ");

            int N = Int32.Parse(Console.ReadLine());

            int a = 1, result = 0;

            while (N > result)
            {
                result += a;
                a++;
                //Console.WriteLine($"{result} {a}");
            }

            Console.WriteLine(a-1);
        }
    }
}
