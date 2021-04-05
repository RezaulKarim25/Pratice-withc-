using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            float Showresult = result(10.4f, 10.6f);
            Console.WriteLine("Show float type result : {0}", Showresult);
            decimal DecumalResult = result(22.88m, 88.12m);
            Console.WriteLine("Show Decimal type result : {0}", DecumalResult);
            string nameOfSchoolFriends = PrimarySchool("one", "Two", "three", "four", "five");
            Console.WriteLine("printed output is : {0}",nameOfSchoolFriends);
            Console.ReadKey();
        }
        static float result(float num, float num1)
        {
            float Result = num + num1;
            return Result;
        }
        static decimal result(decimal num, decimal num1)
        {
            decimal Result = num + num1;
            return Result;
        }
        static string PrimarySchool(string One, string Two, string Three, string Four, string Five)
        {
            string Allclassare = One + " " + Two + " " + Three + " " + Four + " " + Five;
            return Allclassare;
        }
    }
}
