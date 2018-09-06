using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Travel travel=new Travel();
            Way way=new Plane();
            travel.setWay(way);
            travel.travel();
        }
    }
    class Travel
    {
        private Way way;
        public void setWay(Way way)
        {
            this.way=way;
        }
        public void travel()
        {
            way.travel();
        }
    }
    abstract class Way
    { 
        public abstract void travel();
    }
    class Plane:Way
    { 
        public override void travel()
        {
            Console.WriteLine("选择飞机出行");
        }
    }
    class Train:Way
    {
        public override void travel()
        {
            Console.WriteLine("选择火车出行");
        }
    }
    class Bike:Way
    {
        public override void travel()
        {
            Console.WriteLine("选择自行车出行");
        }
    }
}
