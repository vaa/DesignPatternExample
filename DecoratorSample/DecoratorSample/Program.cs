using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("汽车形态技能:");
            Tranformer car = new Car();
            car.skill();

            Console.WriteLine("机器人形态技能:");
            Tranformer robot = new Robot(car);
            robot.skill();

            Console.WriteLine("飞机形态技能:");
            Tranformer airPlane = new Airplane(car);
            airPlane.skill();

        }
    }
}
