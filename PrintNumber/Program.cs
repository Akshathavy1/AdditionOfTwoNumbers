using System;

namespace PrintNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the starting range : ");
            int startingRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the ending range : ");
            int endingRange = Convert.ToInt32(Console.ReadLine());
            for (int i = startingRange; i <= endingRange; i++ )
            {
                Console.Write(i + ",");
            }
            Console.Read();

        }
    }
}
