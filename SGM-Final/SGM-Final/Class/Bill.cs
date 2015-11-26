using System;
﻿using System.Linq;

namespace SGM_Final
{
	public class Bill
	{
		public Bill ()
		{
		}

		public double calculate(Order order)
		{
			return order.getProducts().Sum(t => t.getPrice() ?? 0);
		}

	}
}

