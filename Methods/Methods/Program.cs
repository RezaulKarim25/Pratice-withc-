using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Calculator
    {
        public int Add(int num1,int num2 )
        {
            return num1 + num2; 

        }
        public decimal Add (decimal num1, int num2)
        {
            return num1 + num2;
        }
        public decimal Add(decimal num1, int num2,int num3)
        {
            return num1 + num2+ num3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            int result = cal.Add(1, 19);
            Console.WriteLine( result);
            Console.ReadKey();
        }
    }
}
