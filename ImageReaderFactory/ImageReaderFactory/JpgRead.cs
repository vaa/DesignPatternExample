using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageReaderFactory
{
    class JpgRead:ImageReader
    {
        public void ReadImage() 
        {
            Console.WriteLine("读取Jpg格式图片。");
        }
    }
}
