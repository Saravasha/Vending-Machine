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
		public override void Examine()
		{
			//Console.WriteLine($"This {ProductName} is pershiable");
		}

		public override void Use()
		{
			Console.WriteLine($"User: This {ProductName} is soo crunchy!!");
		}

		public override string ToString()
		{
			return ProductName + " is crispy";
		}
	}
}
