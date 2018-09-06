using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplianceFactory
{
    class TCLFactory : ApplianceFactory
    {
        public Television CreateTelevision() 
        {
            return new TCLTelevision();
        }
        public AirConditioner CreateAirConditioner() 
        {
            return new TCLAirConditioner();
        }
    }
}
