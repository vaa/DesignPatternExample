using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplianceFactory
{
    interface ApplianceFactory
    {
        Television CreateTelevision();
        AirConditioner CreateAirConditioner();

    }
}
