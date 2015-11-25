using System;
using System.Collections.Generic;

namespace SGM_Final
{
	public class Order
	{
		private List<Product> products;

		public Order ()
		{
			products = new List<Product> ();
		}

		public List<Product> getProducts()
		{
			return products;
		}

		public void addProduct(Product product)
		{
			if (product != null) {
				products.Add (product);
			}
		}
			
	}
}

