using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer_to_the_Question_no_02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region// Assign variable and using arithmetic operator  

            int a = 10;
            int b = 15;
            int c = a + b;
            Console.WriteLine(c);
            int Sum, Sub, Mul, Div;
            Sum = a + b;
            Console.WriteLine("sumation :" + Sum);
            Sub = a - b;
            Console.WriteLine("subtruction :" + Sub);
            Mul = a * b;
            Console.WriteLine("Multipication :" + Mul);
            Div = a / b;
            Console.WriteLine("Divided :" + Div);
            Console.ReadKey();

            #endregion

            #region // different postfix & pretfix
            //postfix
            //Console.WriteLine("Difference of postfix & prefix :");
            //Console.WriteLine("postfix");
            //int z = 7;
            //Console.WriteLine(z);
            //Console.WriteLine(z++);
            //Console.WriteLine(z);

            //prefix
            //Double p = 7.30;
            //Console.WriteLine("prefix");
            //Console.WriteLine(p);
            //Console.WriteLine(++p);
            //Console.WriteLine(p);

            //prefix
            for (int i = 0; i < 3; ++i)
            {
                int j = ++i;
                Console.WriteLine(j);

            }
            // postfix
            for (int i = 0; i < 10; i++)
            {
                int j = i++;
                Console.WriteLine(j);

            }
            Console.ReadKey();

            #endregion


        }

    }
}
