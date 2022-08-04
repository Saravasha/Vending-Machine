using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    public class VM : IVending
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
        public int[] moneyDenomination = new[]
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
            Console.Write("Vending Machine: Meep morp - Please insert money (Valid types are:)");

            foreach (var money in moneyDenomination)
            {
                Console.Write($"{money}, ");
            }
            string insertValidation = Console.ReadLine();
            int validationToInt = Convert.ToInt32(insertValidation);

            //foreach (var money in moneyDenomination)

                if (ValidateMoneyInput(validationToInt))
                {

                    UpdateSaldo(validationToInt);
                    Console.WriteLine($"Vending Machine: {validationToInt} kr is acceptable input, updating saldo");
                    
                }
                else
                {
                    Console.WriteLine($"Oh, you have a {insertValidation} dollar bill do you?");

                }
        }

        public bool ValidateMoneyInput(int insertedAmount)
        {
            if (moneyDenomination.Contains(insertedAmount))
                return true;
            else
                return false;
            //saldo += moneyDenomination;
        }

        public void UpdateSaldo(int moneyDenomination)
        {
            saldo += moneyDenomination;
        }

        // Show All
        public void ShowAll()
        {
            Console.WriteLine("id:\tname:\t\t\t\t\tprice:\tdescription:");
            foreach (Products p in Products)
            {
                Console.WriteLine($"{p.ID}\t{p.ProductName}\t\t\t\t\t{p.ProductPrice}\t{p.ToString()}");
            }
        }

        // Purchase
        public void Purchase()
        {
            ShowAll();
            Console.Write($"Vending Machine: Saldo is {saldo} kr\nSelect an item to purchase by ID followed by Enter, select Q to go back to the Menu:");
            string purchaseMenuOption = Console.ReadLine();
            if (purchaseMenuOption.Contains('Q') || purchaseMenuOption.Contains('q'))
            {
                Console.WriteLine("Contains Q");
                ChooseOption();
            }

            foreach (Products p in Products)
            {
                if (p.ID.Equals(Convert.ToInt32(purchaseMenuOption)))
                {
                    //while (saldo > p.ProductPrice )
                    {
                        saldo -= p.ProductPrice;
                        Console.WriteLine($"Vending Machine: {p.ProductName} purchased for {p.ProductPrice} kr!");
                        //p.Use();
                        OptionToUseOrExamine(p);
                    }
                } 
            }
        }

        public void OptionToUseOrExamine(Products p)
        {
            Console.WriteLine($"User: What do I want to do with this {p.ProductName}\n" +
                $"1. Use it,\n"+
                $"2. Examine it,\n"+
                $"3. Go back to the menu"

                );
            bool runMe = true;
            while (runMe)
            {
                char k = Console.ReadKey().KeyChar;
                switch (k)
                {
                    case '1':
                        p.Use();
                        ChooseOption();
                        break;
                    case '2':
                        p.Examine();
                        ChooseOption();
                        break;
                    case '3':
                        ChooseOption();
                        break;
                    default:
                        break;
                }
            }
        }
        // End Transaction
        public void EndTransaction()
        {
            Console.WriteLine($"Vending Machine: You get {saldo} kr back in change divided by:");
            DenominationDivider();
        } 

        public void DenominationDivider()
        {
            for (int i = moneyDenomination.Length - 1; i >= 0; i--)
            {
                if (saldo / moneyDenomination[i] >=1) 
                {
                    int x = saldo / moneyDenomination[i];
                    Console.WriteLine($"{x} x {moneyDenomination[i]} kr Denomination");
                    saldo %= moneyDenomination[i];
                }
            }   
        }

        public void ChooseOption()
        {
            Console.WriteLine("Vending Machine: " + "- Hello User, I am Vending Machine");
            bool runMe = true;
            while (runMe)
            {
            Console.WriteLine("Vending Machine: " + "Please select an action to perform from the menu below:\n" +
                "1. Insert Money\n" +
                "2. Purchase\n" +
                "3. Good Bye");
                Console.Write("Vending Machine: Directive?:");

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
                        EndTransaction();
                        Environment.Exit(0);
                        break;
                    default:
                        runMe = false;
                        break;
                }
            }
        }
    }
}
