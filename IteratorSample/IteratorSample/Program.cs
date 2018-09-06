using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> products = new List<object>();
            products.Add("手机");
            products.Add("内存条");
            products.Add("鼠标");
            products.Add("键盘");
            products.Add("显示器");
            AbstractObjectList list=new ProductList(products);
            AbstractIterator iterator = list.CreateIterator();
            Console.WriteLine("正向遍历：");
            while (!iterator.IsLast()) 
            {
                Console.Write(iterator.GetNextItem()+",");
                iterator.Next();
            }
            Console.WriteLine("\n反向遍历：");
            while (!iterator.IsFirst())
            {
                Console.Write(iterator.GetPreviousItem() + ",");
                iterator.Previous();
            }
            Console.WriteLine();
        }
    }
    abstract class AbstractObjectList 
    {
        protected List<object> objects = new List<object>();
        public AbstractObjectList(List<object> objects) 
        {
            this.objects = objects;
        }
        public void AddObject(object obj) 
        {
            this.objects.Add(obj);
        }
        public void RemoveObject(object obj)
        {
            this.objects.Remove(obj);
        }
        public List<object> GetObjects() 
        {
            return this.objects;
        }
        public abstract AbstractIterator CreateIterator();
    }
    class ProductList : AbstractObjectList
    {
        public ProductList(List<object> products) :base(products)
        {
        }
        public override AbstractIterator CreateIterator()
        {
            return new MyIterator(this);
        }
    }
    interface AbstractIterator 
    {
        void Next();
        bool IsLast();
        void Previous();
        bool IsFirst();
        object GetNextItem();
        object GetPreviousItem();
    }
    class MyIterator : AbstractIterator 
    {
        private ProductList productList;
        private List<object> products;
        private int cursor1;
        private int cursor2;
        public MyIterator(ProductList list) 
        {
            this.productList = list;
            this.products = list.GetObjects();
            cursor1 = 0;
            cursor2 = products.Count - 1;
        }
        public void Next() 
        {
            if (cursor1 < products.Count) 
            {
                cursor1++;
            }
        }
        public bool IsLast() 
        {
            return (cursor1 == products.Count);
        }
        public void Previous() 
        {
            if (cursor2 > -1) 
            {
                cursor2--;
            }
        }
        public bool IsFirst()
        {
            return (cursor2 == -1);
        }
        public object GetNextItem()
        {
            return products[cursor1];
        }
        public object GetPreviousItem()
        {
            return products[cursor2];
        }
    }
}
