using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeSample
{
    abstract class AbstractFruit
    {
        public abstract void add(AbstractFruit fruit);
        public abstract void remove(AbstractFruit fruit);
        public abstract AbstractFruit getChild(int i);
        public abstract void eat();
    }

    class Plate :AbstractFruit
    {
        private List<AbstractFruit> fruitList = new List<AbstractFruit>();
        private string name;
        public Plate(string name) 
        {
            this.name = name;
        } 
        public override void add(AbstractFruit fruit) 
        {
            fruitList.Add(fruit);
        }
        public override void remove(AbstractFruit fruit) 
        {
            fruitList.Remove(fruit);
        }
        public override AbstractFruit getChild(int i) 
        {
            return (AbstractFruit)fruitList[i] ;
        }
        public override void eat() 
        {
            Console.WriteLine ("吃"+name+"中水果:");
            foreach (AbstractFruit fruit in fruitList) 
            {
                fruit.eat();
            }
        }
    }

    class Apple : AbstractFruit
    {
        public override void add(AbstractFruit fruit)
        {
            Console.WriteLine("不支持该方法");
        }
        public override void remove(AbstractFruit fruit)
        {
            Console.WriteLine("不支持该方法");
        }
        public override AbstractFruit getChild(int i)
        {
            Console.WriteLine("不支持该方法");
            return null;
        }
        public override void eat()
        {
            Console.WriteLine("吃苹果");
        }
    }

    class Banana : AbstractFruit
    {
        public override void add(AbstractFruit fruit)
        {
            Console.WriteLine("不支持该方法");
        }
        public override void remove(AbstractFruit fruit)
        {
            Console.WriteLine("不支持该方法");
        }
        public override AbstractFruit getChild(int i)
        {
            Console.WriteLine("不支持该方法");
            return null;
        }
        public override void eat()
        {
            Console.WriteLine("吃香蕉");
        }
    }

    class Pear : AbstractFruit
    {
        public override void add(AbstractFruit fruit)
        {
            Console.WriteLine("不支持该方法");
        }
        public override void remove(AbstractFruit fruit)
        {
            Console.WriteLine("不支持该方法");
        }
        public override AbstractFruit getChild(int i)
        {
            Console.WriteLine("不支持该方法");
            return null;
        }
        public override void eat()
        {
            Console.WriteLine("吃梨子");
        }
    }
}
