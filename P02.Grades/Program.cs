using System;

namespace P02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            Grades(input);
        }
        static void Grades(double input)
        {
            if (input >= 2 && input <= 2.99) 
            {
                Console.WriteLine("Fail");
            }
            else if (input >= 3 && input <= 3.49) { Console.WriteLine("Poor"); }
            else if (input >= 3.5 && input <= 4.49) { Console.WriteLine("Good"); }
            else if (input >= 4.5 && input <= 5.49) { Console.WriteLine("Very good"); }
            else if (input >= 5.5 && input <= 6) { Console.WriteLine("Excellent"); }
        }
    }
}
