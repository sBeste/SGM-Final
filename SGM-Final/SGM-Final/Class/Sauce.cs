using System;

namespace SGM_Final
{
	public class Sauce : Product
	{
		public static Sauce MAYO = new Sauce("Mayo", 0.2);
		public static Sauce KETCHUP = new Sauce("Ketchup", 0.2);

		private String name;
		private double price;

		private Sauce (String name, double price)
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
	