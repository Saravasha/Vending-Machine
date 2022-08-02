using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
	internal class Snacks : Products
	{
		public Snacks(string ProductName, int ProductPrice) : base(ProductName, ProductPrice)
		{

		}

		public new void Examine()
		{
			Console.WriteLine($"{ProductName} is perishable");
		}

		public new void Use()
		{
			Console.WriteLine($"This {ProductName} is crispy");
		}
	}
}
