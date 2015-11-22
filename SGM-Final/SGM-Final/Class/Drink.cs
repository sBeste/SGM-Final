using System;

namespace SGM
{
	public class Drink : Product
	{
		public static Drink COLA = new Drink("Cola", 1.0);
		public static Drink SPRITE = new Drink("Sprite", 1.0);
		public static Drink FANTA = new Drink("Fanta", 1.0);
		public static Drink WATER = new Drink("WATER", 1.0);

		private String name;
		private double price;

		private Drink (String name, double price)
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