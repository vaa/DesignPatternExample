using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee cat = new Cat();
            Target dog = new Dog();
            cat = new Adapter(dog);
            cat.CatCatchMouse();
            cat.DogCry();
        }
    }
}
