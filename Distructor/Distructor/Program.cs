using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distructor
{
    class Example
    {
        public Example()
        {
            Console.WriteLine("Constructor Called");
        }
        // Distructor
        ~Example()
        {
            // TO Do: clean up unmanaged objects
            Console.WriteLine("Distructor called to clean up unmanaged objects");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            Console.ReadKey();
        }
    }
}
