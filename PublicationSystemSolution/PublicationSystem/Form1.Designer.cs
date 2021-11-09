
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
			this.editBtn = new System.Windows.Forms.Button();
			this.bDeleteBtn = new System.Windows.Forms.Button();
			this.searchBox = new System.Windows.Forms.TextBox();
			this.searchBy = new System.Windows.Forms.ComboBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.datePicker1 = new System.Windows.Forms.DateTimePicker();
			this.datePicker2 = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Location = new System.Drawing.Point(136, 71);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ReadOnly = true;
			this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid.Size = new System.Drawing.Size(765, 313);
			this.dataGrid.TabIndex = 1;
			// 
			// getBooks
			// 
			this.getBooks.Location = new System.Drawing.Point(38, 71);
			this.getBooks.Name = "getBooks";
			this.getBooks.Size = new System.Drawing.Size(75, 23);
			this.getBooks.TabIndex = 2;
			this.getBooks.Text = "Get Books";
			this.getBooks.UseVisualStyleBackColor = true;
			this.getBooks.Click += new System.EventHandler(this.getBooks_Click);
			// 
			// addBookBtn
			// 
			this.addBookBtn.Location = new System.Drawing.Point(38, 199);
			this.addBookBtn.Name = "addBookBtn";
			this.addBookBtn.Size = new System.Drawing.Size(75, 23);
			this.addBookBtn.TabIndex = 3;
			this.addBookBtn.Text = "Add book";
			this.addBookBtn.UseVisualStyleBackColor = true;
			this.addBookBtn.Click += new System.EventHandler(this.addBookBtn_Click);
			// 
			// editBtn
			// 
			this.editBtn.Location = new System.Drawing.Point(38, 113);
			this.editBtn.Name = "editBtn";
			this.editBtn.Size = new System.Drawing.Size(75, 23);
			this.editBtn.TabIndex = 4;
			this.editBtn.Text = "Edit";
			this.editBtn.UseVisualStyleBackColor = true;
			this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
			// 
			// bDeleteBtn
			// 
			this.bDeleteBtn.Location = new System.Drawing.Point(38, 156);
			this.bDeleteBtn.Name = "bDeleteBtn";
			this.bDeleteBtn.Size = new System.Drawing.Size(75, 23);
			this.bDeleteBtn.TabIndex = 5;
			this.bDeleteBtn.Text = "Delete";
			this.bDeleteBtn.UseVisualStyleBackColor = true;
			this.bDeleteBtn.Click += new System.EventHandler(this.bDeleteBtn_Click);
			// 
			// searchBox
			// 
			this.searchBox.Location = new System.Drawing.Point(393, 31);
			this.searchBox.Name = "searchBox";
			this.searchBox.Size = new System.Drawing.Size(205, 20);
			this.searchBox.TabIndex = 6;
			// 
			// searchBy
			// 
			this.searchBy.FormattingEnabled = true;
			this.searchBy.Location = new System.Drawing.Point(241, 30);
			this.searchBy.Name = "searchBy";
			this.searchBy.Size = new System.Drawing.Size(127, 21);
			this.searchBy.TabIndex = 7;
			this.searchBy.SelectedIndexChanged += new System.EventHandler(this.searchBy_SelectedIndexChanged);
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(38, 240);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 23);
			this.searchBtn.TabIndex = 8;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// datePicker1
			// 
			this.datePicker1.Location = new System.Drawing.Point(393, 31);
			this.datePicker1.Name = "datePicker1";
			this.datePicker1.Size = new System.Drawing.Size(200, 20);
			this.datePicker1.TabIndex = 9;
			// 
			// datePicker2
			// 
			this.datePicker2.Location = new System.Drawing.Point(626, 31);
			this.datePicker2.Name = "datePicker2";
			this.datePicker2.Size = new System.Drawing.Size(200, 20);
			this.datePicker2.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1050, 450);
			this.Controls.Add(this.datePicker2);
			this.Controls.Add(this.datePicker1);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.searchBy);
			this.Controls.Add(this.searchBox);
			this.Controls.Add(this.bDeleteBtn);
			this.Controls.Add(this.editBtn);
			this.Controls.Add(this.addBookBtn);
			this.Controls.Add(this.getBooks);
			this.Controls.Add(this.dataGrid);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.Button getBooks;
		private System.Windows.Forms.Button addBookBtn;
		private System.Windows.Forms.Button editBtn;
		private System.Windows.Forms.Button bDeleteBtn;
		private System.Windows.Forms.TextBox searchBox;
		private System.Windows.Forms.ComboBox searchBy;
		private System.Windows.Forms.Button searchBtn;
		private System.Windows.Forms.DateTimePicker datePicker1;
		private System.Windows.Forms.DateTimePicker datePicker2;
	}
}

