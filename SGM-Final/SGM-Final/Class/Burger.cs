using System;

namespace SGM_Final
{
	public class Burger : Product
	{
		public static Burger HAMBURGER = new Burger("Hamburger", 2.0);
		public static Burger CHEESEBURGER = new Burger("ChesseBurger", 2.5);
		public static Burger CHICKENBURGER = new Burger("Chickenburger", 3.0);

		private string name;
		private double price;

		private Burger (String name, double price)
		{
			this.name = name;
			this.price = price;
		}

		double Product.getPrice() {
			return this.price;
		}

		String Product.getName()
		{
			return this.name;
		}

	}
}

