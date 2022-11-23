using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string value :");
            string name = Console.ReadLine();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");

            }
            Console.Read();

        }
    }
}
