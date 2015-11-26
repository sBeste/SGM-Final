using System;

namespace SGM_Final
{
	public class Bill
	{
		public Bill ()
		{
		}

		public double calculate(Order order)
		{
			return Product.Sum(t => t.getPrice() ?? 0);
		}

	}
}

