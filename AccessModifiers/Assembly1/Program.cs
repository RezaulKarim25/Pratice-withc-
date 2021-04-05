using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
   public class Assembly1baseclass
   {
        private string privateVariable = "private";
        protected string protectedVariable = "protected";
        internal string internalVariable = "internal";
        protected internal string protectedinternalVariable = "protectedinternal";
        public string publicvariable = "public";
        public void TestAccess()
        {
            //Accessible
            Console.WriteLine(privateVariable);
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedinternalVariable);
            Console.WriteLine(publicvariable);
        }
    }
    public class Assembly1Drivedclass : Assembly1baseclass 
    {
        public void TestAccessinDrivedClass()
        {
            // Not Accessible
            //Console.WriteLine(privateVariable);
            // Accessible
            Console.WriteLine(protectedVariable);
            Console.WriteLine(internalVariable);
            Console.WriteLine(protectedinternalVariable);
            Console.WriteLine(publicvariable);
        }
    }
    public class Assembly1Otherclass
    {
        public void TestAccess()
        {
            //Not Accessible
            Assembly1baseclass objBase = new Assembly1baseclass();
            //Console.WriteLine(objBase.privateVariable);           
            //Console.WriteLine(objBase.protectedVariable);

            // Accessible
            Console.WriteLine(objBase.internalVariable);
            Console.WriteLine(objBase.protectedinternalVariable);
            Console.WriteLine(objBase.publicvariable);

        }
    }
    

        class Program
    {
        static void Main(string[] args)
        {
            //Assembly1baseclass objBase = new Assembly1baseclass();
            //objBase.TestAccess();
            //Assembly1Drivedclass objinDrivedClass = new Assembly1Drivedclass();
            //// objinDrivedClass.TestAccessinDrivedClass();
            //objinDrivedClass.TestAccess();
            Assembly1Otherclass objother = new Assembly1Otherclass();
            objother.TestAccess();
            Console.ReadKey();
        }
    }
}
