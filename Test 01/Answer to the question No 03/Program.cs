using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answer_to_the_question_No_03
{
    #region // Method, scope,Perameter,optional perameters and nameing arguments. 


    class Program
    {
        public static int result = 0; // global scope available in other class also
        static int n = 0;

        static void Main(string[] args)
        {
            // Specify both named parameters.
            AddStudent(subject: "CSE", studentName: "Ahamed Hridoy");  //Named Arguments

            AddStudent("Megna Ray", "IT");

            AddStudent("Asraful Alom");

            DoSum(7, 5);

            Console.WriteLine(result); 
            Console.WriteLine(n); // n is available here because it is global scope but not outside the class
            Console.ReadKey();
        }



        static void DoSum(int num1, int num2) // method
        {
            int total = num1 + num2; // total is local scope variable
            result = total;
            Console.WriteLine("{0} + {1}", num1, num2, total);

        }

        static void AddStudent(string studentName, string subject = "CSE") // here studentName is mendetory param and subject is optional param
        {
            Console.WriteLine("Student Name = {0}, Subject = {1}", studentName, subject);
        }
        

    }
    #endregion
}

