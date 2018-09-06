using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape shape;
                shape = ShapeFactory.GetShape("circle");
                shape.draw();
                shape.erase(); 
                shape = ShapeFactory.GetShape("rectangle");
                shape.draw();
                shape.erase();
                shape = ShapeFactory.GetShape("triangle");
                shape.draw();
                shape.erase();
                shape = ShapeFactory.GetShape("circl");
                shape.draw();
                shape.erase();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
