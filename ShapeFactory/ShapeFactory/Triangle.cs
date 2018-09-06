using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeFactory
{
    class Triangle : Shape
    {
        public void draw() 
        {
            Console.WriteLine("绘制Triangle图。");
        }
        public void erase()
        {
            Console.WriteLine("擦除Triangle图。");
        }
    }
}