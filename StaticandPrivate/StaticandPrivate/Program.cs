using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticandPrivate
 {
    public class Example
    {
        public static int Counter;
        // Private constructor.
        private  Example()
        {
            Counter = 10;

        }
        // Static Constractor 
        static Example()
        {
            Counter = 20;

        }
        public Example(int counter)
        {
            Counter = Counter + counter;

        }
        public static int Getcount()
    {
        return ++Counter;
    }
        public class nestedExample
        {
            public void Test()
            {
                // Internal instance
                Example ex = new Example();

            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //External instance
            //Example ex = new Example();

            Example ex = new Example(10);
            Console.WriteLine("Counter: {0}",Example.Getcount());
            Console.ReadKey();
        }
    }
 }
