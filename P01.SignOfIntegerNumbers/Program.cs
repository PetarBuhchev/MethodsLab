using System;

namespace P01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Check(input);
        }
        static void Check(int input)
        {
            if (input == 0)
            {
                Console.WriteLine($"The number {input} is zero.");
            }
            else if (input > 0)
            {
                Console.WriteLine($"The number {input} is positive.");
            }
            else
            {
                Console.WriteLine($"The number {input} is negative.");
            }
        }
    }
}
