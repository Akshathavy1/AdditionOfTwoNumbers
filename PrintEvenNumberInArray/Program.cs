using System;

namespace PrintEvenNumberInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 32, 4, 10, 13, 17, 34, 44 };
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.Read();
        }
    }
}
