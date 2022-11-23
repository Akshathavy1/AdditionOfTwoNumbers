using System;

namespace DoWhileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number :");
            int num = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(num);
                num++;
            }
            while (num < 20);

            Console.Read();
        }
    }
}
