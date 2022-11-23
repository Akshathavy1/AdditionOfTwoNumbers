using System;

namespace ReverseANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int reverse = 0;
            Console.WriteLine("enter the numbers :");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number / 10;

            }
            Console.WriteLine("the reversed number is :" + reverse);
            Console.Read();
        }
    }
}
