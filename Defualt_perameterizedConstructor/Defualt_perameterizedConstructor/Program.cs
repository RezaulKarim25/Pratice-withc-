using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defualt_perameterizedConstructor
{
    class Student
    {
        //Defualt Constructor
        public int StudentId { get; set; }
        public String Name { get; set; }
        public String College { get; set; }
        public Student()
        {
            College =  "KPI";
        }
        // perameterizer Constructor
        public Student(int StudentId, string name, string collage)
        {
            this.StudentId = StudentId;
            this.Name = name;
            this.College = collage;
           
        }
        public Student(int StudentId, string name)
        {
            this.StudentId = StudentId;
            this.Name = name;          

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student stu = new Student();
            //Console.WriteLine("StudentId : {0}, Name: {1}, College : {2}", stu.StudentId, stu.Name, stu.College);
            //Student stu = new Student(1,"Rezaul Karim","KPI");
            //Console.WriteLine("StudentId : {0}, Name: {1}, College : {2}", stu.StudentId, stu.Name, stu.College);
            Student stu = new Student(1, "Rezaul Karim");
            Console.WriteLine("StudentId : {0}, Name: {1}", stu.StudentId, stu.Name);
            Console.ReadKey();
        } 
    }
}
