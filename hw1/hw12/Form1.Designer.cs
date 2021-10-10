
namespace hw12
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
			this.importBtn = new System.Windows.Forms.Button();
			this.studentGrid = new System.Windows.Forms.DataGridView();
			this.addBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// importBtn
			// 
			this.importBtn.Location = new System.Drawing.Point(36, 23);
			this.importBtn.Name = "importBtn";
			this.importBtn.Size = new System.Drawing.Size(75, 23);
			this.importBtn.TabIndex = 0;
			this.importBtn.Text = "Import";
			this.importBtn.UseVisualStyleBackColor = true;
			this.importBtn.Click += new System.EventHandler(this.importBtn_Click);
			// 
			// studentGrid
			// 
			this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.studentGrid.Location = new System.Drawing.Point(36, 67);
			this.studentGrid.Name = "studentGrid";
			this.studentGrid.Size = new System.Drawing.Size(715, 345);
			this.studentGrid.TabIndex = 1;
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(139, 23);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 2;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.studentGrid);
			this.Controls.Add(this.importBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button importBtn;
		private System.Windows.Forms.DataGridView studentGrid;
		private System.Windows.Forms.Button addBtn;
	}
}

