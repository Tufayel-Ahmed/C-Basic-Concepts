using System;

namespace BitwiseOperator
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

            Swap(num1, num2);
            string result = CheckEvenOdd(num1);
            
            Console.WriteLine(result);

        }

        public static void Swap(int num1, int num2)
        {
            num1 = num1 ^ num2;
            num2 = num2 ^ num1;
            num1 = num1 ^ num2;

            Console.WriteLine($"First number: {num1}");
            Console.WriteLine($"Second number: {num2}");
        }

        public static string CheckEvenOdd(int num1)
        {
            if ((num1 & 1) == 1)
            {
                return "The first number is odd";
            }
            else
            {
                return "The first number is even";
            }
        }
    }
}
