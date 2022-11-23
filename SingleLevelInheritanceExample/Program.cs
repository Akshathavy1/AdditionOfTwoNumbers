using System;

namespace SingleLevelInheritanceExample
{
    public class Animal
    {
        public void noise()
        {
            Console.WriteLine("animals make some noise");
        }
    }
    public class cat : Animal
    {
        static void Main(string[] args)
        {
            cat obj = new cat();
            obj.noise();
            Console.Read();
        }
    }
}