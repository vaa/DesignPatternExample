using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageReaderFactory
{
    class Gif:Image
    {
        public void CreateImage() 
        {
            Console.WriteLine("创建Gif格式图片。");
        }
    }
}
