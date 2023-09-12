using System;

namespace P03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            if (command == "add") 
            {
                Add(num, num1); 
            }
            else if (command == "multiply")
            {
                Multiply(num, num1);
            }
            else if (command == "subtract")
            {
                Subtract(num, num1);
            }
            else
            {
                Divide(num, num1);
            }
        }
        static void Add(int num, int num1)
        {
            Console.WriteLine(num+num1);
        }
        static void Multiply(int num, int num1) 
        {
            Console.WriteLine(num*num1);
        }
        static void Subtract(int num, int num1) 
        {
            Console.WriteLine(num-num1);
        }
        static void Divide(int num, int num1) 
        {
            Console.WriteLine(num/num1);
        }
    }
}
