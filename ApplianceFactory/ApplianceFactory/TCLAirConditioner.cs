using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplianceFactory
{
    class TCLAirConditioner : AirConditioner
    {
        public void changeTemperature()
        {
            Console.WriteLine("TCL空调调节温度");
        }
    }
}
