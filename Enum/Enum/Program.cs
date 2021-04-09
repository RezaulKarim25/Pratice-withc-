using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student st = new Student();
            Student st = Student.Sayem;
            Console.WriteLine(st);

            int Total= Batch47(12, 3);
            Console.WriteLine("All Students are : {0} ", Total);

            Teacher tc = Teacher.AbdulBaten;
            Console.WriteLine(tc);
            Console.ReadKey();

        }
        public enum Student 
        {
            Sakib, Sharmin, Bappy, Sayem


        }
        
        public static int Batch47(int Boys,int Girls)
        {
            int Students=Boys + Girls;
            return Students;
        }
        public enum Teacher
        {
            RahadSharif,AbdulBaten,AbuSayedChoudhori,ForidaBanu
        }
    }

}
