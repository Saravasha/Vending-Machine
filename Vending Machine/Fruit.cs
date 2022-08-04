using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal class Fruit : Products
    {
        public Fruit(string ProductName, int ProductPrice) : base(ProductName, ProductPrice)
        {

        }

        public override void Examine()
        {
            Console.WriteLine($"This {ProductName} is best enjoyed as soon as possible");
        }

        public override void Use()
        {
            Console.WriteLine($"User: This {ProductName} is soo juicy!");
        }

        public override string ToString()
        {
            return ProductName + " is juicy";
        }

    }
}
