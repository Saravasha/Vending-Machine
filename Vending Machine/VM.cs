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


        public int InsertMoney() {
            var insertValidation = Convert.ToInt32(Console.ReadLine());
            
            foreach (var money in MoneyDenominations)
            
                if (insertValidation == money) {
                    saldo += money;
                    return saldo;
                }
                else
                {
                    Console.WriteLine($"Oh, you have a {insertValidation} dollar bill do you?");
                    return saldo;
                }
            return saldo;
        }
    
        public List<Products> Products;
        public void CreateProductList()
        {
            Fruit fruit = new Fruit("Banana", 6);
            Products.Add(fruit);
            fruit = new Fruit("Apple", 5);
            Products.Add(fruit);
            fruit = new Fruit("Orange", 12);
            Products.Add(fruit);

            Drinks drinks = new Drinks("Fanta", 13);
            Products.Add(drinks);
            drinks = new Drinks("Coca-Cola Zero", 13);
            Products.Add(drinks);
            drinks = new Drinks("Monster: Mango Loco", 26);
            Products.Add(drinks);

            Snacks snacks = new Snacks("Estrella: Sourcream and Onion", 14);
            Products.Add(snacks);
            snacks = new Snacks("Beef Jerky", 36);
            Products.Add(snacks);
            snacks = new Snacks("Lays: Salt and Vinegar", 13);
            Products.Add(snacks);

        }

        public void ShowAll()
        {
            Console.WriteLine("id:\tname:\t\t\t\t\tprice:");
            foreach(Products p in Products)
            {
                Console.WriteLine($"{p.ID}\t{p.ProductName}\t\t\t\t\t{p.ProductPrice}"); 
            }
        }
    }
}
