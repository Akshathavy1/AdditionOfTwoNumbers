using System;

namespace ArrayAscendingOrderExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 32, 4, 10, 13, 17, 34, 44 };
            for (int i = 0; i < array.Length - 1; i++)//index comparision
            {
                for (int j = 0; j < array.Length - 1; j++)// values comparision
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            /*for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }*/
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.Read();
        }
    }
}
