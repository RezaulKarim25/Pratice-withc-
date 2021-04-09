using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Interface
{
    
      class Horse: ILandBond, IJourney
      {
            int ILandBond.NumberOfLegs()
            {
                return 4;
            }
            int IJourney.NumberOfLegs()
            {
                return 3;
            }
      }

    
}
