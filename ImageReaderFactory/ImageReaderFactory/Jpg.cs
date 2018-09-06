using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageReaderFactory
{
    class Jpg:Image
    {
        public void CreateImage() 
        {
            Console.WriteLine("创建Jpg格式图片。");
        }
    }
}
