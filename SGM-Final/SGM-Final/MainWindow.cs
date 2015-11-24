using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
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
            MessageBox.Show("Hier neues Fenster für eine neue Bestellung");
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
    }
}
