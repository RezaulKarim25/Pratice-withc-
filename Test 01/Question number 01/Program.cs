using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_number_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region           //if..else
            int a = 10;
            if(a>7)
            {
                Console.WriteLine("a is biger then 7");

            }
            else
            {
                Console.WriteLine("a is less then 7");

            }
            Console.ReadKey();
            #endregion

            #region //Switch 
            int session=6;
            switch(session)
            {
               case 1:
                    Console.WriteLine("Summer");
                    break;
                case 2:
                    Console.WriteLine("Rainy ");
                    break;
                case 3:
                    Console.WriteLine("Autumn");
                    break;
                case 4:
                    Console.WriteLine("Fall ");
                    break;
                case 5:
                    Console.WriteLine("winter");
                    break;
                case 6:
                    Console.WriteLine("spring ");
                    break;
                default:
                    Console.WriteLine("!opps");
                    break;

            }
            Console.ReadKey();
            #endregion

            #region  //While loop
            int x = 100;
            while (x <= 110) 
            {
                Console.WriteLine(x);
                x++;
            }
            Console.ReadKey();

            #endregion

            #region  //for loop

            for (int h = 1; h < 55; h++)
            {
                Console.WriteLine(h);
                h=h+1;
            }
            Console.ReadKey();

            #endregion

            #region //Do
            int j = 0;
            do
            {
                 
                Console.WriteLine(j);
                j++;
            }
            while (j < 5);
           

            Console.ReadKey();
            #endregion

            #region  // For eatch loop
            String[] Laibarys = { "PHP", "C#", "English", "Java", "C", "C++" };

            foreach (String Laibary in Laibarys)
            {
                Console.WriteLine(Laibary);
                Console.ReadKey();
            }

            #endregion
        }

    }
}
