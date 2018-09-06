using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeFactory
{
    class Circle:Shape
    {
        public void draw() 
        {
            Console.WriteLine("绘制Circle图。");
        }
        public void erase()
        {
            Console.WriteLine("擦除Circle图。");
        }
    }
}
