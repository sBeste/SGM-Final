namespace SGM_Final
{
	partial class addCustomerWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.vornameField = new System.Windows.Forms.TextBox();
			this.budgetField = new System.Windows.Forms.TextBox();
			this.nachnameField = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.addCustomerToQueueButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// vornameField
			// 
			this.vornameField.Location = new System.Drawing.Point(570, 137);
			this.vornameField.Name = "vornameField";
			this.vornameField.Size = new System.Drawing.Size(285, 26);
			this.vornameField.TabIndex = 0;
			// 
			// budgetField
			// 
			this.budgetField.Location = new System.Drawing.Point(570, 232);
			this.budgetField.Name = "budgetField";
			this.budgetField.Size = new System.Drawing.Size(285, 26);
			this.budgetField.TabIndex = 2;
			// 
			// nachnameField
			// 
			this.nachnameField.Location = new System.Drawing.Point(570, 182);
			this.nachnameField.Name = "nachnameField";
			this.nachnameField.Size = new System.Drawing.Size(285, 26);
			this.nachnameField.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(466, 140);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 20);
			this.label4.TabIndex = 4;
			this.label4.Text = "Vorname";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(466, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 20);
			this.label5.TabIndex = 5;
			this.label5.Text = "Nachname";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(466, 235);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 20);
			this.label6.TabIndex = 6;
			this.label6.Text = "Budget";
			// 
			// addCustomerToQueueButton
			// 
			this.addCustomerToQueueButton.Location = new System.Drawing.Point(627, 310);
			this.addCustomerToQueueButton.Name = "addCustomerToQueueButton";
			this.addCustomerToQueueButton.Size = new System.Drawing.Size(165, 49);
			this.addCustomerToQueueButton.TabIndex = 7;
			this.addCustomerToQueueButton.Text = "Hinzufügen";
			this.addCustomerToQueueButton.UseVisualStyleBackColor = true;
			// 
			// addCustomerWindow
			// 
			this.ClientSize = new System.Drawing.Size(1408, 554);
			this.Controls.Add(this.addCustomerToQueueButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.nachnameField);
			this.Controls.Add(this.budgetField);
			this.Controls.Add(this.vornameField);
			this.Name = "addCustomerWindow";
			this.Load += new System.EventHandler(this.addCustomerWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button addCustomerButton;
		private System.Windows.Forms.TextBox vornameField;
		private System.Windows.Forms.TextBox budgetField;
		private System.Windows.Forms.TextBox nachnameField;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button addCustomerToQueueButton;

	}
}