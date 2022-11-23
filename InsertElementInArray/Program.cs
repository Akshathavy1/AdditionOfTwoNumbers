using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertElementInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr =new int[] { 2, 5, 32, 4, 10, 13, 17, 34, 44 };

            arr[5] = 17;
            for(int i=0;i<arr.Length; i++) 
            {
                Console.WriteLine(arr[i]);
            }
            Console.Read();
        }
    }
}
