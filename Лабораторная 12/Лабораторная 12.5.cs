using System;
using System.Dynamic;

namespace Лабораторная_12._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; string b = "год";

            Console.Write("Введите год: ");

            a = Int32.Parse(Console.ReadLine());

            string[] arr = new string[] { " крысы", " коровы", " тигра", " зайца", " дракона", " змеи", " лошади", " овцы", " обезьяны", " курицы", " собаки", " свиньи" };

            string[] arr2 = new string[] { " зеленой", " красной", " желтой", " белой", " черной" };

            string[] arr3 = new string[] { " зеленого", " красного", " желтого", " белого", " черного" };

            a -= 1983;

            a = a % 60;

            if (a % 12 + 1 == 3 || a % 12 + 1 == 4 || a % 12 + 1 == 5)
            {
                b += arr3[a / 12];
            }
            else
            {
                b += arr2[a / 12];
            }
            switch (a % 12)
            {
                case 0:
                    b += arr[11];
                    break;
                case 1:
                    b += arr[0];
                    break;
                case 2:
                    b += arr[1];
                    break;
                case 3:
                    b += arr[2];
                    break;
                case 4:
                    b += arr[3];
                    break;
                case 5:
                    b += arr[4];
                    break;
                case 6:
                    b += arr[5];
                    break;
                case 7:
                    b += arr[6];
                    break;
                case 8:
                    b += arr[7];
                    break;
                case 9:
                    b += arr[8];
                    break;
                case 10:
                    b += arr[9];
                    break;
                case 11:
                    b += arr[10];
                    break;
                default:
                    break;
            }

            Console.WriteLine(b);
        }
    }
}
