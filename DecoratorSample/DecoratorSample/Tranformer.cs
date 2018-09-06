using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorSample
{
    abstract class Tranformer
    {
        public abstract void skill();
    }

    class Car : Tranformer
    {
        public override void skill()
        {
            move();
        }
        public void move() 
        {
            Console.WriteLine("移动");
        }
    }

    class Changer : Tranformer
    {
        Tranformer tranformer;
        public Changer(Tranformer tranformer) 
        {
            this.tranformer = tranformer;
        }
        public override void skill()
        {
            tranformer.skill();
        }
    }

    class Robot : Changer
    {
        public Robot(Tranformer tranformer) :base(tranformer)
        {
        }
        public override void skill()
        {
            base.skill();
            say();
        }
        public void say()
        {
            Console.WriteLine("说话");
        }
    }

    class Airplane : Changer
    {
        public Airplane(Tranformer tranformer) :base(tranformer)
        {
        }
        public override void skill()
        {
            base.skill();
            fly();
        }
        public void fly()
        {
            Console.WriteLine("飞翔");
        }
    }
}
