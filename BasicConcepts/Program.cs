using System;

namespace BasicConcepts
{
    class Program
    {
        public static void Main(String[] args)
        {
            Input();
        }

        public static void Input()
        {
            Console.Write("Enter Bengali marks: ");
            double bengali = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter English marks: ");
            double english = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Mathematics marks: ");
            double math = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Computer Studies marks: ");
            double computer = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Science marks: ");
            double science = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Average Result: {CalculateResult(bengali, english, math, computer, science)}");
        }
        
        public static double CalculateResult(double bengali, double english, double math, double computer, double science)
        {
            return  (bengali + english + math + computer + science) / 5.0;
        }
    }
}