using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplianceFactory
{
    class HaierAirConditioner:AirConditioner
    {
        public void changeTemperature() 
        {
            Console.WriteLine("Haier空调调节温度");
        }
    }
}
