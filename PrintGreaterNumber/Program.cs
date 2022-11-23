using System;

namespace PrintGreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 32, 4, 10, 13, 17, 34, 44 };

          // Array.Sort(arr);
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                if (arr[i] > 20)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.Read();
        }
    }
}
