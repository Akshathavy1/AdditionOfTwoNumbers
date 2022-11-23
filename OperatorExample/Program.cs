using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the  first numbers :");
            int number1=int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the  second numbers :");
            int number2 = int.Parse(Console.ReadLine());
            int addition=number1+ number2;
            Console.WriteLine("addition of two number is :"+addition);
            int sub = number1 - number2;
            Console.WriteLine("subtraction of two number is :"+sub);
            int mul=number1 * number2;
            Console.WriteLine("multiplication of two number is "+mul);
            int div=number1/number2;
            Console.WriteLine("division of two number is :"+div);
            int remain=number1%number2;
            Console.WriteLine("remainder of the number :"+remain);
            addition -= 3;
            Console.WriteLine("decremented by 3 :"+addition);
            sub += 8;
            Console.WriteLine("incremented by 8 :" + sub);
            mul--;
            Console.WriteLine(mul);
            div++;
            Console.WriteLine(div);
           if(number1 == number2)
            {
                Console.WriteLine("both are equal");

            }
            else if(number2 !=number1) 
            {
                Console.WriteLine("both are not equal");
            }
            if(addition<mul&& sub>=div)
            {
                Console.WriteLine("both condition are satisfied");

            }
            else if(addition==number1 || addition<=sub)
            {
                Console.WriteLine("any one condition is satisfied");
            }
            else
            {
                Console.WriteLine("conditions are not satisfied");
            }


            Console.Read();

        }
    }
}
