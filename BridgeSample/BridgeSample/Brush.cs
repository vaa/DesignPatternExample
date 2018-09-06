using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeSample
{
    abstract class Brush
    {
        protected Color color;
        public void setColor(Color color) 
        {
            this.color = color;
        }
        public abstract void draw();
    }

    class LargeBrush :Brush
    {
        public override void draw()
        {
            color.setColor();
            Console.WriteLine("大号画笔绘图");

        }
    }

    class MediumBrush : Brush
    {
        public override void draw()
        {
            color.setColor();
            Console.WriteLine("中号画笔绘图");

        }
    }

    class SmallBrush : Brush
    {
        public override void draw()
        {
            color.setColor();
            Console.WriteLine("小号画笔绘图");

        }
    }
}
