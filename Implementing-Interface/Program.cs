using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Interface
{
    class Program
    { 
        static void Main(string[] args)
        {
            Horse horse = new Horse();
            //int legs = horse.NumberOfLegs();
            //Not Compile

            IJourney journeyHorse = horse;
            int legsInJourney = journeyHorse.NumberOfLegs();
            Console.WriteLine(legsInJourney);

            ILandBond landBondHorse = horse;
            int legsOnHorse = landBondHorse.NumberOfLegs();
            Console.WriteLine(legsOnHorse);
            Console.ReadKey();
        }       
    }
}
