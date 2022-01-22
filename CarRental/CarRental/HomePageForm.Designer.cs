
namespace CarRental {
	partial class HomePageForm {
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
			this.importBtn = new System.Windows.Forms.Button();
			this.mainGrid = new System.Windows.Forms.DataGridView();
			this.addUserBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// importBtn
			// 
			this.importBtn.Location = new System.Drawing.Point(26, 25);
			this.importBtn.Name = "importBtn";
			this.importBtn.Size = new System.Drawing.Size(75, 23);
			this.importBtn.TabIndex = 0;
			this.importBtn.Text = "Import";
			this.importBtn.UseVisualStyleBackColor = true;
			this.importBtn.Click += new System.EventHandler(this.impotBtn_Click);
			// 
			// mainGrid
			// 
			this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mainGrid.Location = new System.Drawing.Point(26, 64);
			this.mainGrid.Name = "mainGrid";
			this.mainGrid.Size = new System.Drawing.Size(700, 329);
			this.mainGrid.TabIndex = 1;
			// 
			// addUserBtn
			// 
			this.addUserBtn.Location = new System.Drawing.Point(686, 25);
			this.addUserBtn.Name = "addUserBtn";
			this.addUserBtn.Size = new System.Drawing.Size(102, 23);
			this.addUserBtn.TabIndex = 2;
			this.addUserBtn.Text = "Add User";
			this.addUserBtn.UseVisualStyleBackColor = true;
			// 
			// HomePageForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addUserBtn);
			this.Controls.Add(this.mainGrid);
			this.Controls.Add(this.importBtn);
			this.Name = "HomePageForm";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button importBtn;
		private System.Windows.Forms.DataGridView mainGrid;
		private System.Windows.Forms.Button addUserBtn;
	}
}

