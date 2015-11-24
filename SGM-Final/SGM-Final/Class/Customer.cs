using System;

namespace SGM_Final
{
	public class Customer
	{
		public string Name {get; private set;}
		public string FirstName {get; private set;}
		public double CreditBalance {get; private set;}
		private Order order;

		public Customer (string FirstName, string Name, double CreditBalance)
		{
			this.FirstName = FirstName;
			this.Name = Name;
			this.CreditBalance = CreditBalance;
			this.order = new Order ();
		}

		public double pay (double amount) {
			this.CreditBalance = this.CreditBalance - amount;

			return this.CreditBalance;
		}

		public void addProduct(Product product)
		{
			if (product != null) {
				order.addProduct (product);
			}
		}
	}
}
