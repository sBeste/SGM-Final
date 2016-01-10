using System;

namespace SGM_Final
{
	public class Sauce : Product
	{
		public static Sauce MAYO = new Sauce("Mayo", 0.2);
		public static Sauce KETCHUP = new Sauce("Ketchup", 0.2);

		private Sauce (String name, double price) : base(name, price)
		{
			products.Add (this);
		}
	}
}
	