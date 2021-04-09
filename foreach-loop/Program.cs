using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_loop
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] FigterAircapter = { "mick29", "Rafail-19", "F-15 Eagles ", "Mazda" };


            foreach (string Airbus in FigterAircapter)

            {
                Console.WriteLine(Airbus);
            }
        //    int[] pins = new int[4] { 9, 3, 7, 2 };// Single dimentional array with int type.
        //String[] Aircapter = { "mick29", "Rafail-19", " F-15 Eagles", "Mazda" };//Single dimentional array with string arry,
        //var names = new[] {new {Name ="Hridoy",Age = 24},
        //                      new {Name ="Dina",Age = 29},
        //                      new {Name ="Rafin",Age = 14},
        //                      new {Name ="Tahmenna",Age = 14}, };

        //String[] array = new string[5];
        //array[0] = "Hridoy";
        //    array[1] = "Dina";
        //    array[2] = "Rafin";
        //    array[3] = "Tahmenna";
        //    array[4] = "Binthy";

        //    Console.WriteLine("All display array");
        //    foreach (string slow in array)
        //    {
        //        Console.WriteLine(array);
        //    }
            Console.ReadKey();

        }      
    }
    
  
    
}
