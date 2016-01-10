using System;
using System.Collections.Generic;

namespace SGM_Final
{
	public abstract class Product
	{

		protected List<Product> products;



		public abstract double getPrice();
		public abstract String getName();
	}
}