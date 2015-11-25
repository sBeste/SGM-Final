using System;

namespace SGM_Final
{
	public class Garnish : Product
	{
		public static Garnish POMMES = new Garnish("Pommes", 1.0);
		public static Garnish SALAd = new Garnish("Salat", 1.0);

		private String name;
		private double price;

		private Garnish (String name, double price)
		{
			this.name = name;
			this.price = price;
		}

		String Product.getName()
		{
			return this.name;
		}

		double Product.getPrice()
		{
			return this.price;
		}
	}
}

