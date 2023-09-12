using System;

namespace P06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine(Area(height, width));
        }
        static double Area(double height, double width)
        {
            return height * width;
        }
    }
}
