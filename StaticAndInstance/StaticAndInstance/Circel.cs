using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstance
{
   class Circel // This is static class.
   {
        public static float pi; // This is static member of class.
        int Radius; // This is instince menber of class.
        static Circel()  // This is static constractor. static constractor doesn't allow peramettar.
        {
            pi = 3.1416F; // Static Constractor value assigend .
        }
        public Circel(int radius) // Parameterise Constractor. Instance constractor allow perametter.
        {
            this.Radius = radius;

        }
        public void getResult()
        {
            Console.WriteLine("Calculated result is: {0}",pi* Radius*Radius);
        }
            

   }

}
