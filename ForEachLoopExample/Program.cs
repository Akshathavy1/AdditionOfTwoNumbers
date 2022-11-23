using System;

namespace ForEachLoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "hello", "hlooo", "byee", "good" };
            foreach (string names in array)
            {
                Console.WriteLine(names);
            }
            Console.Read();
        }
    }
}
