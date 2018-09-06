using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFruit plate1,plate2,fruit1,fruit2,fruit3;
            plate1 = new Plate("大水果盘");
            plate2 = new Plate("小水果盘");
            fruit1 = new Apple();
            fruit2 = new Banana();
            fruit3 = new Pear();
            plate1.add(fruit1);
            plate2.add(fruit2);
            plate2.add(fruit3);
            plate1.add(plate2);
            plate1.eat();
        }
    }
}
