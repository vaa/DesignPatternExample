using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeFactory
{
    class Rectangle: Shape
    {
        public void draw() 
        {
            Console.WriteLine("绘制Rectangle图。");
        }
        public void erase()
        {
            Console.WriteLine("擦除Rectangle图。");
        }
    }
}
