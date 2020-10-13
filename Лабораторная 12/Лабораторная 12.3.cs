using System;
using System.Reflection.Metadata.Ecma335;

namespace Лабораторная_12._3
{
    class Program
    {
        static string foo(int x)
        {
            string[] arr = new string[] { "одно", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

            string output = "";

            if( x / 10 == 1) 
            {
                switch (x%10)
                {
                    case 0:
                        output = "Десять";
                        break;
                    case 1:
                        output = "Одиннцадцать";
                        break;
                    case 2:
                        output = "Двенадцать";
                        break;
                    case 3:
                        output = "Тринадцать";
                        break;
                    case 4:
                        output = "Четырнадцать";
                        break;
                    case 5:
                        output = "Пятнадцать";
                        break;
                    case 6:
                        output = "Шестнадцать";
                        break;
                    case 7:
                        output = "Семнадцать";
                        break;
                    case 8:
                        output = "Восемнадцать";
                        break;
                    case 9:
                        output = "Девятнадцать";
                        break;
                    default:
                        break;
                }
            }
            else 
            {
                switch (x / 10) 
                {
                    case 2:
                        output = "Двадцать";
                        break;
                    case 3:
                        output = "Тридцать";
                        break;
                    case 4:
                        output = "Сорок";
                        break;

                      
                }
                switch (x%10)
                {
                    case 1:
                        output +=" " + arr[x % 10 - 1];
                        break;
                    case 2:
                        output += " " + arr[x % 10 - 1];
                        break;
                    case 3:
                        output += " " + arr[x % 10 - 1];
                        break;
                    case 4:
                        output += " " + arr[x % 10 - 1];
                        break;
                    case 5:
                        output += " " + arr[x % 10 - 1];
                        break;
                    case 6:
                        output += " " + arr[x % 10 - 1];
                        break;
                    case 7:
                        output += " " + arr[x % 10 - 1];
                        break;
                    case 8:
                        output += " " + arr[x % 10 - 1];
                        break;
                    case 9:
                        output += " " + arr[x % 10 - 1];
                        break;
                    default:
                        break;
                }
            }
            if (x % 10 == 1)
            {
                output += " учебное задание"; 
            }
            else
            {
                output += " учебных занятий";
            }

            return output;
        }
        static void Main(string[] args)
        {
            int a;

            Console.Write("Введите количество заданий: ");

            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine(foo(a));
        }
    }
}
