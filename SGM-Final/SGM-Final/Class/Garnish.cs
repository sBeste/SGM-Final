using System;

namespace SGM_Final
{
	public class Garnish : Product
	{
		public static Garnish POMMES = new Garnish("Pommes", 1.0);
		public static Garnish SALAD = new Garnish("Salat", 1.0);

		private Garnish (String name, double price) : base(name, price)
		{
			products.Add (this);
		}
	}
}