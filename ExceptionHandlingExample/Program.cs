using System;

namespace ExceptionHandlingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("enter the numerator :");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the denominator :");
                int number2 = int.Parse(Console.ReadLine());
                int number3 = number1 / number2;
                Console.WriteLine(number3);
            }
            catch (Exception ex)
            {
                Console.WriteLine("please enter valid input\n  " + ex.ToString());
            }
            Console.Read();

        }
    }
}
