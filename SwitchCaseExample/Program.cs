using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 5;
            switch(day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                    case 2:
                    Console.WriteLine("Monday");
                    break;
                    case 3:
                    Console.WriteLine("Tuesday");
                    break;
                    case 4:
                    Console.WriteLine("Wednesday");
                    break;
                    case 5:
                    Console.WriteLine("Friday");
                    break;
                    case 6:
                    Console.WriteLine("saturday");
                    break;
                default:
                    Console.WriteLine("day is not found");
                    break;
            }
            Console.Read();
        }
    }
}
