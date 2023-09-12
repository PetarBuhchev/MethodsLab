using System;

namespace P05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            if (product == "coffee")
            {
                Coffee(product, quantity);
            }
            else if (product == "water") 
            {
                Water(product, quantity);
            }
            else if (product == "coke")
            {
                Coke(product, quantity);
            }
            else
            {
                Snacks(product, quantity);
            }
        }
        static void Coffee(string product, int quantity) 
        {
            double price = quantity * 1.50;
            Console.WriteLine($"{price:f2}");
        }
        static void Water(string product, int quantity) 
        {
            double price = quantity * 1.00;
            Console.WriteLine($"{price:f2}");
        }
        static void Coke(string product, int quantity) 
        {
            double price = quantity * 1.40;
            Console.WriteLine($"{price:f2}");
        }
        static void Snacks(string product, int quantity) 
        {
            double price = quantity * 2.00;
            Console.WriteLine($"{price:f2}");
        }
    }
}
