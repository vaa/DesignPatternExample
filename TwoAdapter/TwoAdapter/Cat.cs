using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoAdapter
{
    public class Cat:Adaptee
    {
        public void CatCatchMouse() 
        {
            Console.WriteLine("Cat Catch Mouse");
        }
        public void CatCry()
        {
            Console.WriteLine("Cat Cry");
        }
    }
}
