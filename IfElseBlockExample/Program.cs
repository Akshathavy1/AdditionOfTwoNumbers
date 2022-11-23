using System;

namespace IfElseBlockExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number:");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("it  is a even number");
            }
            else
            {
                Console.WriteLine("it is a odd number");
            }
            Console.Read();
        }
    }
}
