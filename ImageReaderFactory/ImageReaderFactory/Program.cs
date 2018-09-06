using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageReaderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageReader factory;
            Image image;
            factory = new GifRead();
            image = new Gif();
            image.CreateImage();
            factory.ReadImage();
            factory = new JpgRead();
            image = new Jpg();
            image.CreateImage();
            factory.ReadImage();
        }
    }
}
