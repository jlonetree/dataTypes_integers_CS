using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 12;
            int num3;
            int sum1 = num1 + num2;

            double d1 = 3.5;
            double d2 = 1.337;
            double sum2 = d1 + d2;

            float f1 = 3.5F;
            float f2 = 4.7F;

            num3 = 5;

            Console.WriteLine("This is the first number " + num1);
            Console.WriteLine("This is the second number " + num2);
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum1)
            Console.WriteLine("The sum of " + d1 + " and " + d2 + " is " + sum2)
            Console.WriteLine("This is number 3 " + num3)
            Console.Read();
        }
    }
}