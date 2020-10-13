using System;
using System.Numerics;

namespace Лабораторная_12
{
    class Program
    {
       static void foo(int x, ref string y)
        {
            switch (x)
            {
                case 1:
                    y = "Первое";
                    break;
                case 2:
                    y = "Второе";
                    break;
                case 3:
                    y = "Третье";
                    break;
                case 4:
                   y = "Четвертое";
                    break;
                case 5:
                   y = "Пятое";
                    break;
                case 6:
                   y = "Шестое";
                    break;
                case 7:
                    y = "Седьмое";
                    break;
                case 8:
                    y = "Восьмое";
                    break;
                case 9:
                    y = "Девятое";
                    break;
                case 10:
                    y = "Десятое";
                    break;
                case 11:
                    y = "Одиннадцатое";
                    break;
                case 12:
                    y = "Двенадцатое";
                    break;
                case 13:
                    y = "Тринадцатое";
                    break;
                case 14:
                    y = "Четырнадцатое";
                    break;
                case 15:
                    y = "Пятнадцатое";
                    break;
                case 16:
                    y = "Шестнадцатое";
                    break;
                case 17:
                    y = "Семнадцатое";
                    break;
                case 18:
                    y = "Восемнадцатое";
                    break;
                case 19:
                    y = "Девятнадцатое";
                    break;
                case 20:
                    y = "Двадцатое";
                    break;
                case 21:
                    y = "Двадцать первое";
                    break;
                case 22:
                    y = "Двадцать второе";
                    break;
                case 23:
                    y = "Двадцать третье";
                    break;
                case 24:
                    y = "Двадцать четвертое";
                    break;
                case 25:
                    y = "Двадцать пятое";
                    break;
                case 26:
                    y = "Двадцать шестое";
                    break;
                case 27:
                    y = "Двадцать седьмое";
                    break;
                case 28:
                    y = "Двадцать восьмое";
                    break;
                case 29:
                    y = "Двадцать девятое";
                    break;
                case 30:
                    y = "Тридцатое";
                    break;
                case 31:
                    y = "Тридцать первое";
                    break;
                default:
                    break;
            }
        }
        static void foo2(int x, ref string y)
        {
            switch (x)
            {
                case 1:
                    y += " января";
                    break;
                case 2:
                    y += " февраля";
                    break;
                case 3:
                    y += " марта";
                    break;
                case 4:
                    y += " апреля";
                    break;
                case 5:
                    y += " мая";
                    break;
                case 6:
                    y += " июня";
                    break;
                case 7:
                    y += " июля";
                    break;
                case 8:
                    y += " августа";
                    break;
                case 9:
                    y += " сентября";
                    break;
                case 10:
                    y += " октября";
                    break;
                case 11:
                    y += " ноября";
                    break;
                case 12:
                    y += " декабря";
                    break;
                default:
                    break;
            }
        }
        static void Main(string[] args)
        {
            int a, b;
            string  data = "";

            Console.Write("Введите день: ");

            a = int.Parse(Console.ReadLine()); 
            
            Console.Write("Введите месяц: ");

            b = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Дата: {a}.{b}");

            foo(a, ref data);
            foo2(b, ref data);

            Console.WriteLine(data);


        }
    }
}