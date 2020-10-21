using System;

namespace Лабораторная_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double price; string n;

            Console.Write("Введите цену за 1 кг: ");

            price = Convert.ToDouble(Console.ReadLine());

            n = Convert.ToString(price);

            n = n.Remove( 0 , n.IndexOf(',')+1);

            double[] arr = new double[] { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1 };

            Console.Clear();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"стоимость {arr[i]} кг конфет {Math.Round((arr[i] * price), n.Length)}");
            }
        }
    }
}
