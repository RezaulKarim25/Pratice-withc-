using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prefix_and_Poatfix
{
    class Program
    {
 
       static void Main(string[] args)
        {
            #region Ans to the Question No. 01
            //Postfix .......
            Console.WriteLine("Deffernce of postfix & pre fix : ");
            Console.WriteLine("Postfix");
            int n = 7;
            Console.WriteLine(n);
            Console.WriteLine(n++);
            Console.WriteLine(n);
            Console.WriteLine("prefix : ");
            //prefix.......
            Double y = 2.5;
            Console.WriteLine(y);
            Console.WriteLine(++y);
            Console.WriteLine(y);
            #endregion 


            #region Ans To the Question No 02

            for (int i = 0; i < 3; ++i)
            {
                int j = ++i;
                Console.WriteLine(j);
            }
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
    

