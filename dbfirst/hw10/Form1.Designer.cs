
namespace hw10 {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.importBtn = new System.Windows.Forms.Button();
			this.productsGrid = new System.Windows.Forms.DataGridView();
			this.searchInput = new System.Windows.Forms.TextBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.repostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.delteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// importBtn
			// 
			this.importBtn.Location = new System.Drawing.Point(22, 57);
			this.importBtn.Name = "importBtn";
			this.importBtn.Size = new System.Drawing.Size(75, 23);
			this.importBtn.TabIndex = 0;
			this.importBtn.Text = "Import";
			this.importBtn.UseVisualStyleBackColor = true;
			this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
			// 
			// productsGrid
			// 
			this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productsGrid.Location = new System.Drawing.Point(12, 86);
			this.productsGrid.Name = "productsGrid";
			this.productsGrid.Size = new System.Drawing.Size(657, 345);
			this.productsGrid.TabIndex = 1;
			// 
			// searchInput
			// 
			this.searchInput.Location = new System.Drawing.Point(119, 60);
			this.searchInput.Name = "searchInput";
			this.searchInput.Size = new System.Drawing.Size(130, 20);
			this.searchInput.TabIndex = 2;
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(271, 59);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 23);
			this.searchBtn.TabIndex = 3;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.repostsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(824, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// categoryToolStripMenuItem
			// 
			this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.delteToolStripMenuItem});
			this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
			this.categoryToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
			this.categoryToolStripMenuItem.Text = "Category";
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editToolStripMenuItem.Text = "Edit";
			this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
			// 
			// repostsToolStripMenuItem
			// 
			this.repostsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem1});
			this.repostsToolStripMenuItem.Name = "repostsToolStripMenuItem";
			this.repostsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.repostsToolStripMenuItem.Text = "Reports";
			// 
			// categoryToolStripMenuItem1
			// 
			this.categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
			this.categoryToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			this.categoryToolStripMenuItem1.Text = "Category";
			this.categoryToolStripMenuItem1.Click += new System.EventHandler(this.categoryToolStripMenuItem1_Click);
			// 
			// delteToolStripMenuItem
			// 
			this.delteToolStripMenuItem.Name = "delteToolStripMenuItem";
			this.delteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.delteToolStripMenuItem.Text = "Delete";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 499);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.searchInput);
			this.Controls.Add(this.productsGrid);
			this.Controls.Add(this.importBtn);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button importBtn;
		private System.Windows.Forms.DataGridView productsGrid;
		private System.Windows.Forms.TextBox searchInput;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem repostsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem delteToolStripMenuItem;
	}
}

