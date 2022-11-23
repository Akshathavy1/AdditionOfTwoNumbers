using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberInCircular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rad = 10;
            double consoleRatio = (4.0 / 2.0);
            double  a=consoleRatio* rad;
            double b = rad;
            for(int y=-rad;y<=rad;y++)
            {
                for(double x=-a;x<=a;x++)
                {
                    double d=(x/a)*(x/a)+(y/a)*(y/a);
                    if(d>0.100 && d<1.2)
                    {
                        Console.Write("2");
                    }
                    else
                    {
                        Console.Write(" ");

                    }
                }
                Console.WriteLine("\n");
            }
            Console.Read();
        }
    }
}