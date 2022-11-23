using System;

namespace PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the starting range :");
            int startingRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the ending range :");
            int endingRange = Convert.ToInt32(Console.ReadLine());
            for (int i = startingRange; i <= endingRange; i++)
            {
                if (i % 2 == 0)
                {
                    System.Threading.Thread.Sleep(100);
                    Console.WriteLine("even numbers are :" + i);
                }
            }
            Console.Read();

        }
    }
}
