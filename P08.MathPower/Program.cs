using System;

namespace P08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());           
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(Powered(baseNum, power));
        }
        static double Powered(double baseNum, double power)
        {
            return Math.Pow(baseNum, power);
        }
    }
}
