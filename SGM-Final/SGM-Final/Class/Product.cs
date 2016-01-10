using System;
using System.Collections.Generic;

namespace SGM_Final
{
	public abstract class Product
	{

		protected static List<Product> products = new List<Product>();
		private string name;
		private double price;

		protected Product(string name, double price)
		{
			this.name = name;
			this.price = price;
		}

		public double getPrice()
		{
			return price;
		}

		public String getName()
		{
			return name;
		}
	}
}