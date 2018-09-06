using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Robot robot = new Adapter(dog);
            Console.WriteLine("机器人模拟：");
            robot.cry();
            robot.move();
        }
    }
}
