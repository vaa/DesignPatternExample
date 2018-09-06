using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeFactory
{
    class ShapeFactory
    {
        public static Shape GetShape(string type) 
        {
            Shape shape = null;
            if (type.Equals("circle"))
            {
                shape = new Circle();
                Console.WriteLine("初始化circle图。");
            }
            else if (type.Equals("rectangle"))
            {
                shape = new Rectangle();
                Console.WriteLine("初始化rectangle图。");
            }
            else if (type.Equals("triangle"))
            {
                shape = new Triangle();
                Console.WriteLine("初始化triangle图。");
            }
            else 
            { 
                throw new UnsupportedShapeException("发生异常：绘制不支持图形。");
            }
            return shape;
        }
    }
}
