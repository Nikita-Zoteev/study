using System;
using System.ComponentModel.Design;
using System.Security.Claims;

namespace Лабораторная__12._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;

            Console.Write("Введите число: ");

            b = Int32.Parse(Console.ReadLine());
            
            string a = "";

            string[] arr = new string[] { " один", " два", " три", " четыре", " пять", " шесть", " семь", " восемь", " девять" };

            string[] arr2 = new string[] { " двадцать", " тридцать", " сорок", " пятьдесят", " шестьдесят", " семьдесят", " восемьдесят", " девяносто" };

            string[] arr3 = new string[] { "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };

            a = arr3[b / 100 - 1];

            if (b%100/10 == 1)
            {
                switch (b % 10)
                {
                    case 0:
                        a += " десять";
                        break;
                    case 1:
                        a += " одиннадцать";
                        break;
                    case 2:
                        a += " двенадцать";
                        break;
                    case 3:
                        a += " тринадцать";
                        break;
                    case 4:
                        a += " четырнадцать";
                        break;
                    case 5:
                        a += " пятнадцать";
                        break;
                    case 6:
                        a += " шестнадцать";
                        break;
                    case 7:
                        a += " семнадцать";
                        break;
                    case 8:
                        a += " восемнадцать";
                        break;
                    case 9:
                        a += " девятнадцать";
                        break;
                    default:
                        break;
                }               
            }
            else
            {
                switch (b%100/10)
                {
                    case 2:
                        a += arr2[0];
                        break;
                    case 3:
                        a += arr2[1];
                        break;
                    case 4:
                        a += arr2[2];
                        break;
                    case 5:
                        a += arr2[3];
                        break;
                    case 6:
                        a += arr2[4];
                        break;
                    case 7:
                        a += arr2[5];
                        break;
                    case 8:
                        a += arr2[6];
                        break;
                    case 9:
                        a += arr2[7];
                        break;
                    default:
                        break;
                }
                switch (b % 10)
                {
                    case 1:
                        a += arr[0];
                        break;
                    case 2:
                        a += arr[1];
                        break;
                    case 3:
                        a += arr[2];
                        break;
                    case 4:
                        a += arr[3];
                        break;
                    case 5:
                        a += arr[4];
                        break;
                    case 6:
                        a += arr[5];
                        break;
                    case 7:
                        a += arr[6];
                        break;
                    case 8:
                        a += arr[7];
                        break;
                    case 9:
                        a += arr[8];
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(a);

        }
    }
}
