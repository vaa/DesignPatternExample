using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplianceFactory
{
    class HaierFactory : ApplianceFactory
    {
        public Television CreateTelevision()
        {
            return new HaierTelevision();
        }
        public AirConditioner CreateAirConditioner()
        {
            return new HaierAirConditioner();
        }
    }
}
