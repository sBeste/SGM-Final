namespace SGM_Final
{
	partial class customerOrderWindow
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
			this.Burger = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Burger
			// 
			this.Burger.Location = new System.Drawing.Point(280, 210);
			this.Burger.Name = "Burger";
			this.Burger.Size = new System.Drawing.Size(75, 54);
			this.Burger.TabIndex = 0;
			this.Burger.Text = "Burger";
			this.Burger.UseVisualStyleBackColor = true;
			this.Burger.Click += new System.EventHandler(this.Burger_Click);
			// 
			// customerOrderWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1520, 734);
			this.Controls.Add(this.Burger);
			this.Name = "customerOrderWindow";
			this.Text = "customerOrderWindow";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button Burger;
	}
}