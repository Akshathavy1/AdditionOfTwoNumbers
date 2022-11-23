using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            Console.WriteLine("please enter your name: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine(name);
            Console.WriteLine("please enter a character: ");
            char character = char.Parse(Console.ReadLine());
            Console.WriteLine(character);
            Console.WriteLine("please enter the decimal number: ");
            double numDec = double.Parse(Console.ReadLine());
            Console.WriteLine(numDec);
            Console.WriteLine("please enter true or false : ");
            bool value = Boolean.Parse(Console.ReadLine());
            Console.WriteLine("its return the value :" + value);
            Console.WriteLine("please enter the largest number: ");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(number);
            Console.WriteLine("please enter the number: ");
            float numF = int.Parse(Console.ReadLine());
            Console.WriteLine(numF);
            Console.WriteLine("please enter the number: ");
            byte numb = byte.Parse(Console.ReadLine());
            Console.WriteLine(numb);








        }
    }
}
