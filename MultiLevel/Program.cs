using System;

namespace MultiLevel
{
    public class Bird
    {
        public void eat()
        {
            Console.WriteLine("birds are eating someting");
           
        }
    }
    public class parrot : Bird
    {
        public void drink()
        {
            Console.WriteLine("parrots are drinking water:");
           
        }
    }
    public class Peacock : parrot
    {
        static void Main(string[] args)
        {
            Peacock obj = new Peacock();
            obj.eat();
            obj.drink();
            Console.Read();
        }

    }

}


