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

        public int saldo = 0;
        private int[] moneyDenomination = new[]
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

        // Insert Money
        public void InsertMoney()
        {
            Console.Write("Please insert money (Valid types are:)");

            foreach (var money in moneyDenomination)
            {
                Console.Write($"{money}, ");
            }
            string insertValidation = Console.ReadLine();
            int test = Convert.ToInt32(insertValidation);

            //foreach (var money in moneyDenomination)

                if (moneyDenomination.Contains(test))
                {

                    UpdateSaldo(test);
                    Console.WriteLine($"{test} is acceptable input, updating saldo");
                    
                }
                else
                {
                    Console.WriteLine($"Oh, you have a {insertValidation} dollar bill do you?");

                }
        }

        public void UpdateSaldo(int moneyDenomination)
        {
            saldo += moneyDenomination;
        }

        // Show All
        public void ShowAll()
        {
            Console.WriteLine("id:\tname:\t\t\t\t\tprice:");
            foreach (Products p in Products)
            {
                Console.WriteLine($"{p.ID}\t{p.ProductName}\t\t\t\t\t{p.ProductPrice}");
            }
            ChooseOption();
        }

        // Purchase
        public void Purchase()
        {

        }

        // End Transaction
        public void EndTransaction()
        {
            Console.WriteLine($"You get {saldo} kr back in change");
        } 

        public void DenominationDivider()
        {

        }

        public void ChooseOption()
        {
            bool runMe = true;
            while (runMe)
            {
            Console.WriteLine("Select an action to perform from the menu below:\n" +
                "1. Insert Money\n" +
                "2. Purchase\n" +
                "3. View Products\n" +
                "4. Good Bye");

            //bool persistMenu = true;
            string readChoice = Console.ReadLine();


                switch (readChoice)
                {
                    case "1":
                        InsertMoney();
                        break;
                    case "2":
                        Purchase();
                        break;
                    case "3":
                        ShowAll();
                        break;
                    case "4":
                        EndTransaction();
                        Environment.Exit(0);
                        break;
                    default:
                        //persistMenu = false;
                        runMe = false;
                        break;

                }
            }
        }
    }
}
