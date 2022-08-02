using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public abstract class Products
    {

        //Products Banana = new Products();
        //Dictionary Product = [
        //    Banana, 5,
        //    Apple, 
        //    "Men's underwear", 
        //    Gerpgork
        //    ]
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ID { get; set; }
        private static int _id = 0;

        public Products(string productName, int productPrice)
        {
            _id++;
            ID = _id;
            ProductName = productName;
            ProductPrice = productPrice;
        }
            
        public void Use()
        {

        }

        public void Examine()
        {

        }

    }
}
