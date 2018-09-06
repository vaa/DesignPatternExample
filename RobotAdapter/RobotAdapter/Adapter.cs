using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotAdapter
{
    class Adapter:Robot
    {
        private Dog dog;
        public Adapter(Dog dog) 
        {
            this.dog = dog;
        }
        public override void cry() 
        {
            dog.dogCry();
        }
        public override void move() 
        {
            dog.dogMove(); 
        }
    }
}
