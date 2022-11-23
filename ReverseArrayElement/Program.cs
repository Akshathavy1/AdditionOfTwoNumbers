using System;

namespace ReverseArrayElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 32, 4, 10, 13, 17, 34, 44 };

            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.Read();
        }
    }
}
