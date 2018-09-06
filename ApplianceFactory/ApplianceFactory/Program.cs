using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplianceFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplianceFactory applianceFactory;
            Television television;
            AirConditioner airConditioner;

            applianceFactory = new HaierFactory();
            television = new HaierTelevision();
            airConditioner = new HaierAirConditioner();
            television=applianceFactory.CreateTelevision();
            airConditioner=applianceFactory.CreateAirConditioner();
            television.play();
            airConditioner.changeTemperature();

            applianceFactory = new TCLFactory();
            television = new TCLTelevision();
            airConditioner = new TCLAirConditioner();
            television = applianceFactory.CreateTelevision();
            airConditioner = applianceFactory.CreateAirConditioner();
            television.play();
            airConditioner.changeTemperature();

        }
    }
}
