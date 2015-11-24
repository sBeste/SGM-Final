namespace SGM_Final
{
	partial class MainWindow
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.orderButton = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kundenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listView1 = new System.Windows.Forms.ListView();
			this.listView2 = new System.Windows.Forms.ListView();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// orderButton
			// 
			this.orderButton.Location = new System.Drawing.Point(606, 267);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(394, 179);
			this.orderButton.TabIndex = 0;
			this.orderButton.Text = "Bestellen";
			this.orderButton.UseVisualStyleBackColor = true;
			this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Location = new System.Drawing.Point(0, 33);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1618, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuStrip2
			// 
			this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.neuToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(1618, 33);
			this.menuStrip2.TabIndex = 4;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// neuToolStripMenuItem
			// 
			this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.kundenToolStripMenuItem,
			this.kasseToolStripMenuItem});
			this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
			this.neuToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
			this.neuToolStripMenuItem.Text = "Neu";
			// 
			// kundenToolStripMenuItem
			// 
			this.kundenToolStripMenuItem.Name = "kundenToolStripMenuItem";
			this.kundenToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
			this.kundenToolStripMenuItem.Text = "Kunden";
			this.kundenToolStripMenuItem.Click += new System.EventHandler(this.kundenToolStripMenuItem_Click);
			// 
			// kasseToolStripMenuItem
			// 
			this.kasseToolStripMenuItem.Name = "kasseToolStripMenuItem";
			this.kasseToolStripMenuItem.Size = new System.Drawing.Size(144, 30);
			this.kasseToolStripMenuItem.Text = "Kasse";
			this.kasseToolStripMenuItem.Click += new System.EventHandler(this.kasseToolStripMenuItem_Click);
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(0, 36);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(260, 747);
			this.listView1.TabIndex = 5;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// listView2
			// 
			this.listView2.Location = new System.Drawing.Point(278, 36);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(260, 747);
			this.listView2.TabIndex = 6;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1618, 780);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip2);
			this.Controls.Add(this.orderButton);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button orderButton;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kundenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kasseToolStripMenuItem;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
	}
}

