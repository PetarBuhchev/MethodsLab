using System;

namespace P11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            if (symbol == "+") 
            {
                Plus(num1,num2);
            }
            else if (symbol == "-") 
            {
                Minus(num1,num2);
            }
            else if (symbol == "*") 
            {
                Umnozhenie(num1,num2);
            }
            else
            {
                Delenie(num1,num2);
            }
        }
        static void Plus(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void Minus(int num1, int num2) 
        {
            Console.WriteLine(num1 - num2);
        }
        static void Umnozhenie(int num1, int num2) 
        {
            Console.WriteLine(num1 * num2);
        }
        static void Delenie(int num1, int num2) 
        {
            Console.WriteLine(num1 / num2);
        }
    }
}
