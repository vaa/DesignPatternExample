using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageReaderFactory
{
    class GifRead:ImageReader
    {
        public void ReadImage() 
        {
            Console.WriteLine("读取Gif格式图片。");
        }
    }
}
