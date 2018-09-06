using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Switch swh = new Switch();
            Command command = new LightCommand();
            swh.Command = command;
            swh.press();
        }
    }
    class Switch
    {
        private Command command;
        internal Command Command
        {
            get { return command; }
            set { command = value; }
        }
        public void press() 
        {
            Console.WriteLine("按下开关");
            Command.execute();
        }
    }
    abstract class Command
    {
        public abstract void execute(); 
    }
    class LightCommand:Command
    {
        private Light light;
        public LightCommand() 
        {
            light = new Light();
        }
        public override void execute()
        {
            light.turnOn();
        }
    }
    class FanCommand : Command
    {
        private Fan fan;
        public FanCommand() 
        {
            fan = new Fan();
        }
        public override void execute()
        {
            fan.open();
        }
    }
    class Light 
    {
        public void turnOn() 
        {
            Console.WriteLine("打开电灯");
        }
    }
    class Fan
    {
        public void open()
        {
            Console.WriteLine("打开电风扇");
        }
    }
}
