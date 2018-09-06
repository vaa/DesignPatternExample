using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplianceFactory
{
    class HaierTelevision : Television
    {
        public void play()
        {
            Console.WriteLine("Haier电视机播放。");
        }
    }
}
