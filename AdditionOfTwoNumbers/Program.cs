using System;

namespace AdditionOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number :");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number :");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double result = number1 + number2;
            Console.WriteLine("addition of two numbers is :" + result);
            Console.Read();

        }
    }
}
