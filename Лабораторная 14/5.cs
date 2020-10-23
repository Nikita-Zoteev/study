using System;

namespace Лабораторная_14._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");

            int A = Int32.Parse(Console.ReadLine());

            Console.Write("Введите B: ");

            int B = Int32.Parse(Console.ReadLine());

            while (A != B)
            {
                if (A > B) A -= B;
                else B -= A;
                
            }

            Console.WriteLine($"НОД = {A}");
        }
    }
}
