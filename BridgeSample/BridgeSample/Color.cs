using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgeSample
{
    interface Color
    {
        void setColor();
    }

    class Red:Color 
    {
        public void setColor()
        {
            Console.Write("红色");
        }
    }

    class Yellow : Color
    {
        public void setColor()
        {
            Console.Write("黄色");
        }
    }

    class Green : Color 
    {
        public void setColor()
        {
            Console.Write("绿色");
        }
    }

    class Blue : Color
    {
        public void setColor()
        {
            Console.Write("蓝色");
        }
    }

    class Purple : Color
    {
        public void setColor()
        {
            Console.Write("紫色");
        }
    }
}
