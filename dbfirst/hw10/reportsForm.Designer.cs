
namespace hw10 {
	partial class reportsForm<T> {
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
			this.reportGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.reportGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// reportGrid
			// 
			this.reportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.reportGrid.Location = new System.Drawing.Point(12, 76);
			this.reportGrid.Name = "reportGrid";
			this.reportGrid.Size = new System.Drawing.Size(501, 243);
			this.reportGrid.TabIndex = 0;
			// 
			// reportsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 352);
			this.Controls.Add(this.reportGrid);
			this.Name = "reportsForm";
			this.Text = "reportsForm";
			((System.ComponentModel.ISupportInitialize)(this.reportGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView reportGrid;
	}
}