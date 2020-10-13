using System;

namespace Лабораторная_12._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string C; int N;

            Console.Write("Введите направление: ");

            C = Convert.ToString(Console.ReadLine());

            Console.Write("Введите действие: ");

            N = Int32.Parse(Console.ReadLine());

            string[] arr = { "Ю", "З", "С", "В" };

            for (int i = 0; i < 4; i++)
            {
                if (C == arr[i])
                {
                    if (N == -1)
                    {
                        if (arr[i] != "Ю")
                        {
                            Console.WriteLine(arr[i + N]);
                        }
                        else
                        {
                            Console.WriteLine(arr[3]);
                        }
                    }
                    if (N == 1)
                    {
                        if (arr[i] != "В")
                        {
                            Console.WriteLine(arr[i + N]);
                        }
                        else
                        {
                            Console.WriteLine(arr[0]);
                        }
                    }
                    if (N == 0)
                    {
                        if (arr[i] != "Ю")
                        {
                            Console.WriteLine(arr[i + N]);
                        }
                        else
                        {
                            Console.WriteLine(arr[3]);
                        }

                    }
                }
            }
        }
    }
}