using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelEachLoopExample
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> integerList = Enumerable.Range(0, 10).ToList();
            List<string> list = new List<string>();
            list.Add("pink");
            list.Add("red");
            list.Add("purple");
            list.Add("blue");
            list.Add("green");


            Parallel.ForEach(list, color =>
            Console.WriteLine("{0},thread id ={1}", color, Thread.CurrentThread.ManagedThreadId));
            Console.Read();
        }
    }
}