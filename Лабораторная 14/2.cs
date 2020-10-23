using System;

namespace Лабораторная_14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввдеите A:");

            int A = Int32.Parse(Console.ReadLine());

            Console.Write("Введите B:");

            int B = Int32.Parse(Console.ReadLine());

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
            }
        }
    }
}
