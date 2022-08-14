using System;

namespace LoopAndIteration
{
    class Program
    {
        public static void Main(String[] args)
        {
            Input();
        }

        public static void Input()
        {
            Console.Write("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            CountNumberOfDigit(num);
            
        }

        public static void CountNumberOfDigit(int num)
        {
            int count = 0;
            int sum = 0;
            int lastDigit = num % 10;
            int firstDigit = 0;
            int product = 1;
            int reverse = 0;
            int n = num;
            if (num == 0)
            {
                Console.WriteLine($"First digit is: 0");
                Console.WriteLine($"Last digit is: 0");
                Console.WriteLine($"Digit of number is: 1");
                Console.WriteLine($"Sum of digit of number is: 0");
                Console.WriteLine($"Product of digit of number is: 0");
            }
            else
            {
                while (num != 0)
                {
                    if (num < 10)
                    {
                        firstDigit = num;
                    }
                    count++;
                    reverse = (reverse * 10) + (num % 10);
                    sum = sum + (num % 10);
                    product = product * (num % 10);
                    num = num / 10;
                }

                Console.WriteLine($"Digit of number is: {count}");
                Console.WriteLine($"First digit is: {firstDigit}");
                Console.WriteLine($"Last digit is: {lastDigit}");
                Console.WriteLine($"Sum of first and last digit is: {firstDigit + lastDigit}");
                Console.WriteLine($"Sum of digit of number is: {sum}");
                Console.WriteLine($"Product of digit of number is: {product}");
                Console.WriteLine($"Reverse of number is: {reverse}");

                if(n == reverse)
                {
                    Console.WriteLine($"{n} is Palindrome.");
                }
                else
                {
                    Console.WriteLine($"{n} is not Palindrome.");
                }
            }
        }
    }
}
