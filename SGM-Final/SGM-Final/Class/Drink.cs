﻿using System;

namespace SGM_Final
{
	public class Drink : Product
	{
		public static Drink COLA = new Drink("Cola", 1.0);
		public static Drink SPRITE = new Drink("Sprite", 1.0);
		public static Drink FANTA = new Drink("Fanta", 1.0);
		public static Drink WATER = new Drink("Wasser", 1.0);

		private String name;
		private double price;

		private Drink (String name, double price)
		{
			this.name = name;
			this.price = price;
		}

		public override String getName()
		{
			return this.name;
		}

		public override double getPrice()
		{
			return this.price;
		}
	}
}