using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstance
{
    class Program
    {
        static void Main(string[] args)
        {
            Circel cr = new Circel(13);
            cr.getResult();
            Circel ch = new Circel(13);
            ch.getResult();
            Circel ch1 = new Circel(13);
            ch1.getResult();
            Circel ch2 = new Circel(13);
            ch2.getResult();
            Console.ReadKey();
            // application of static class member. It's not possible for multitimes call. It's use for single time.
            Console.WriteLine("value of pi is: {0}",Circel.pi);
            Console.ReadKey();
        }

    }
}
