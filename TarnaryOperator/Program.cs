using System;

namespace TarnaryOperator
{
    class Program
    {
        public static void Main(String[] args)
        {
            Input();
        }

        public static void Input()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int result1 = FindMaximumNumber(num1, num2, num3);
            Console.Write($"{result1} is maximum.");

            Console.WriteLine();
            Console.Write("Enter the year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            string result = CheckLeapYear(year);
            Console.WriteLine($"{year} is {result}.");

        }

        public static int FindMaximumNumber(int num1, int num2, int num3)
        {
            int result = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;
            return result;
        }

        public static string CheckLeapYear(int year)
        {
            string result = (year % 4 == 00 && year % 100 != 0) ? "leap year" : (year % 400 == 0) ? "leap year" : "not leap year";
            return result;
        }
    }
}
