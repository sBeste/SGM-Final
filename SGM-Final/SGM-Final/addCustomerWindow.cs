﻿using System;
using System.Windows.Forms;

namespace SGM_Final
{
	public partial class addCustomerWindow : Form
	{
		public addCustomerWindow()
		{
			InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void addCustomerButton_Click(object sender, EventArgs e)
		{
			//Kasse erstellen - @ToDo: An zentrale stelle verschieben
			Cashdesk cashDesk = new Cashdesk ();

			Customer newCustomer = new Customer (this.textBox1.Text, this.textBox2.Text, Convert.ToDouble(this.textBox3.Text));

			//Kunden einreihen
			cashDesk.Queue.Enqueue (newCustomer);
		}
	}
}
