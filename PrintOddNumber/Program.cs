using System;

namespace PrintOddNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the starting range of the loop :");
            int startingRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the ending range of the loop :");
            int endingRange = Convert.ToInt32(Console.ReadLine());
            for (int i = startingRange; i <= endingRange; i++)
            {
                if (i % 2 == 1)
                {
                    // System.Threading.Thread.Sleep(100);
                    Console.WriteLine("odd numbers are :" + i);
                }

            }
            Console.Read();
        }
    }
}
