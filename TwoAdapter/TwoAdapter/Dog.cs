using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoAdapter
{
    class Dog:Target
    {
        public void DogCry() 
        {
            Console.WriteLine("Dog Cry");
        }
        public void DogCatchMouse() 
        {
            Console.WriteLine("Dog Catch Mouse");
        }
    }
}
