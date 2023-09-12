using System;

namespace P10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int length = input.Length;
            char[] inputChar = input.ToCharArray();

            for (int i = 0; i < inputChar; i++)
            {
                if (inputChar[i] == "-" || inputChar[i] == "+")
                {
                    length--;
                    break;
                }
            }
            int[] intArray = new int[length];
        }
    }
}
