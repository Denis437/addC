using System;

namespace ProductLib
{
    public class Product1
    {
        public Product1(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public string Name { get; private protected set; }
        public double Price { get; private protected set; }
        public int Count { get; private protected set; }
        public double Q
        {
            get
            {
                return Math.Round(Price / Count, 2);
            }
        }
        public virtual void Print()
        {
            Console.WriteLine($"Product : {Name}\r\nPrice : {Price}\r\nCount : {Count}\r\nQuality : {Q}\r\n");
        }
    }
}
