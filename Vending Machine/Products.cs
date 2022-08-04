using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public abstract class Products
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ID { get; set; }
        private static int _id = 0;

        public Products(string productName, int productPrice)
        {
            //_id++;
            ID = _id++;
            ProductName = productName;
            ProductPrice = productPrice;
        }
            
        public virtual void Examine()
        {
            Console.WriteLine($"This {ProductName} is pershiable");
        }
        public virtual void Use()
        {
            
        }

        public override string ToString()
        {
            return ProductName + " is pershiable";
        }
    }
}
