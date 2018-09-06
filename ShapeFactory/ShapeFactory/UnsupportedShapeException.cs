using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeFactory
{
    class UnsupportedShapeException:ApplicationException
    {
        string message="绘制不支持几何图形。";
        public UnsupportedShapeException() { }
        public UnsupportedShapeException(string message):base(message) { }
    }
}
