using System;

namespace IfElseConditionalOperator
{
    class Program
    {
        public static void Main(String[] args)
        {
            Input();
        }

        public static void Input()
        {
            Console.Write("Enter your electricity as unit: ");
            int unit = Convert.ToInt32(Console.ReadLine());

            double bill = CalculateBill(unit);
            Console.WriteLine($"Electricity bill is: {bill} Taka");
        }

        public static double CalculateBill(int unit)
        {
            double bill = 0.0;

            if(unit <= 50)
            {
                bill = unit * 0.50;
            }
            else if(unit <= 150)
            {
                bill = 25 + ((unit - 50) * 0.75);
            }
            else if(unit <= 250)
            {
                bill = 100 + ((unit - 150) * 1.20);
            }
            else if( unit > 250){
                bill = 220 + ((unit - 250) * 1.50);
            }

            return (bill + (bill * 0.20));
        }
    }
}
