using System;
using System.Windows.Forms;

namespace SGM_Final
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void orderButton_Click(object sender, EventArgs e)
		{
			customerOrderWindow newCustomerOrder = new customerOrderWindow();
			newCustomerOrder.ShowDialog(); 
		}

		private void kundenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			addCustomerWindow newCustomer = new addCustomerWindow();
			newCustomer.ShowDialog();
		}

		private void kasseToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void MainWindow_Load(object sender, EventArgs e)
		{

		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
