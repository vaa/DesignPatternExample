using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplianceFactory
{
    class TCLTelevision : Television
    {
        public void play() 
        {
            Console.WriteLine("TCL电视机播放。");
        }
    }
}
