using System;

namespace P07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string repeat = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            RepeatString(repeat, times);
        }
        static void RepeatString(string repeat, int times)
        {
            for (int i = 1; i <= times; i++) 
            {
                Console.Write(repeat);
            }
        }
    }
}
