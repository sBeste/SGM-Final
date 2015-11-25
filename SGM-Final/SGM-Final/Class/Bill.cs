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
			double result = 0;

			foreach (Product product in order.getProducts())
			{
				result = result + product.getPrice();
			}

			return result;
		}

	}
}

