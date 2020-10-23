using System;

namespace Лабораторная_14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите процент: ");

            double P = Int32.Parse(Console.ReadLine());

            P /= 100;

            double S = 1000; int K = 0;

            while(S < 1100)
            {
                K += 1;
                S += S * P;
            }

            string sFormated = S.ToString("#.###");

            Console.WriteLine($"Кол-во месяцев = {K}, итоговый вклад = {sFormated}");

        }
    }
}
