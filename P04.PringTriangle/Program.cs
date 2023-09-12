using System;

namespace P04.PrintTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Triangle(input);
        }
        static void Triangle(int input)
        {
            int[] arrayInput = new int[input];
            for (int i = 1; i <= input; i++)
            {
                arrayInput[i - 1] = i;
                for (int j = 0; j < input; j++)
                {
                    if (arrayInput[j] == 0)
                    { continue; }
                    Console.Write(arrayInput[j] + " ");
                }
                Console.WriteLine();
            }
            //До тук е средата
            for (int i = input - 1; i >= 1; i--)
            {
                for (int m = 0; m <= i - 1; m++)
                {
                    Console.Write(arrayInput[m] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
