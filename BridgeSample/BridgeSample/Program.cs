using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Brush brush = new LargeBrush();
            Color color=new Red();
            brush.setColor(color);
            brush.draw();

        }
    }
}
