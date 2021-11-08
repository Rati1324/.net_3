
namespace PublicationSystem
{
	partial class Form1
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
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.getBooks = new System.Windows.Forms.Button();
			this.addBookBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Location = new System.Drawing.Point(12, 76);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(765, 313);
			this.dataGrid.TabIndex = 1;
			// 
			// getBooks
			// 
			this.getBooks.Location = new System.Drawing.Point(12, 26);
			this.getBooks.Name = "getBooks";
			this.getBooks.Size = new System.Drawing.Size(75, 23);
			this.getBooks.TabIndex = 2;
			this.getBooks.Text = "Get Books";
			this.getBooks.UseVisualStyleBackColor = true;
			this.getBooks.Click += new System.EventHandler(this.getBooks_Click);
			// 
			// addBookBtn
			// 
			this.addBookBtn.Location = new System.Drawing.Point(702, 26);
			this.addBookBtn.Name = "addBookBtn";
			this.addBookBtn.Size = new System.Drawing.Size(75, 23);
			this.addBookBtn.TabIndex = 3;
			this.addBookBtn.Text = "Add book";
			this.addBookBtn.UseVisualStyleBackColor = true;
			this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addBookBtn);
			this.Controls.Add(this.getBooks);
			this.Controls.Add(this.dataGrid);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.Button getBooks;
		private System.Windows.Forms.Button addBookBtn;
	}
}

