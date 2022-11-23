using System;

namespace PrintTables
{
    internal class Program
    {
        static void Table(int number)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number+"x"+i+"="+number*i);
            }
        }
        static void Main(string[] args)
        {
            Table(5);
            Console.Read();
        }
    }
}
