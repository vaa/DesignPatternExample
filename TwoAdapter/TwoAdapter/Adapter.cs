using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoAdapter
{
    class Adapter:Target,Adaptee
    {
        private Adaptee adaptee;
        private Target target;
        public Adapter( Target target) 
        {
            this.target = target;
        }
        public Adapter(Adaptee adaptee) 
        {
            this.adaptee = adaptee;
        }
        public void CatCry() 
        {
            target.DogCry();
        }
        public void DogCatchMouse()
        {
            adaptee.CatCatchMouse();
        }
    }
}
