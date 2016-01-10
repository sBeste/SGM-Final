using System;

namespace SGM_Final
{
	public class Burger : Product
	{
		public static Burger HAMBURGER = new Burger("Hamburger", 2.0);
		public static Burger CHEESEBURGER = new Burger("ChesseBurger", 2.5);
		public static Burger CHICKENBURGER = new Burger("Chickenburger", 3.0);

		private Burger (String name, double price) : base(name, price)
		{
			products.Add (this);
		}
	}
}

