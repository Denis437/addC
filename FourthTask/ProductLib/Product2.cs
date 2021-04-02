using System;
using System.Collections.Generic;
using System.Text;

namespace ProductLib
{
    public class Product2 : Product1
    {
        public Product2(string name, double price, int count, int p) : base(name, price, count)
        {
            P = p;
        }
        public int P { get; private set; }
        public double Qp
        {
            get
            {
                return Q + 0.5 * (DateTime.Now.Year - P);
            }
        }
        public override void Print()
        {
            Console.WriteLine($"Product : {Name}\r\nPrice : {Price}\r\nCount : {Count}\r\nQuality : {Q}\r\nYear created : {P}\r\nQuality2 : {Qp}");
        }
    }
}
