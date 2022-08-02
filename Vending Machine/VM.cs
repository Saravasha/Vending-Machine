using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    internal class VM : IVending
    {

        public VM()
        {
            Products = new List<Products>();
            CreateProductList();
        }
        public int saldo = 0;
        private int[] MoneyDenominations = new[]
       {
            1,
            5,
            10,
            20,
            50,
            100,
            500,
            1000
        };

        public List<Products> Products;
        public void CreateProductList()
        {
            Fruit fruit = new Fruit("Banana", 6);
            Products.Add(fruit);
            fruit = new Fruit("Apple", 5);
            Products.Add(fruit);
        }

        public void ShowAll()
        {
            Console.WriteLine("id:\tname:\t\tprice:");
            foreach(Products p in Products)
            {
                Console.Write($"{p.ID}\t{p.ProductName}\t\t{p.ProductPrice}");
            }
        }
    }
}
