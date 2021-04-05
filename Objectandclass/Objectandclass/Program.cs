using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objectandclass
{
    class Program
    {
        // This is class
        class student
        {
            // Fields
            public int StudentID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }

            // This is method
            public void ShowDetaile()
            {
                Console.WriteLine("Student Information");                
                Console.WriteLine("StudentID : {0}, Name : {1}, Address : {2}", StudentID, Name,Address);

            }
        }
        
        static void Main(string[] args)
        {
            // This is a object
            student stu = new student() { StudentID = 1, Name = "Hridoy", Address = "Bhangamore" };
            stu.ShowDetaile();
            Console.ReadKey();


        }
    }
}
