using System;
using System.ComponentModel.DataAnnotations;

namespace P09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "string")
            {
                string str1 = Console.ReadLine();
                string str2 = Console.ReadLine();
                Console.WriteLine(GetMax(str1,str2));
            }
            else if (input == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1,num2));
            }
            else if (input == "char")
            {
                char input1 = char.Parse(Console.ReadLine());
                char input2 = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(input1,input2));
            }
        }
        static string GetMax(string str1, string str2)
        {
            int result = str1.CompareTo(str2);
            if (result>0)
            {
                return str1;
            }
            else
            {
                return str2;
            }
        }
        static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static char GetMax(char input1, char input2)
        {
            int result = input1.CompareTo(input2);
            if (result > 0)
            {
                return input1;
            }
            else { return input2;}
        }
    }
}
