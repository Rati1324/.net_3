
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
			this.impotBtn = new System.Windows.Forms.Button();
			this.mainGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.mainGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// impotBtn
			// 
			this.impotBtn.Location = new System.Drawing.Point(26, 25);
			this.impotBtn.Name = "impotBtn";
			this.impotBtn.Size = new System.Drawing.Size(75, 23);
			this.impotBtn.TabIndex = 0;
			this.impotBtn.Text = "Import";
			this.impotBtn.UseVisualStyleBackColor = true;
			this.impotBtn.Click += new System.EventHandler(this.impotBtn_Click);
			// 
			// mainGrid
			// 
			this.mainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mainGrid.Location = new System.Drawing.Point(26, 64);
			this.mainGrid.Name = "mainGrid";
			this.mainGrid.Size = new System.Drawing.Size(614, 329);
			this.mainGrid.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainGrid);
			this.Controls.Add(this.impotBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.mainGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button impotBtn;
		private System.Windows.Forms.DataGridView mainGrid;
	}
}

