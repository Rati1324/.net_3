
namespace hw10 {
	partial class categoryEdit {
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
			this.label1 = new System.Windows.Forms.Label();
			this.idInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.nameInput = new System.Windows.Forms.TextBox();
			this.agreeBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID:";
			// 
			// idInput
			// 
			this.idInput.Location = new System.Drawing.Point(77, 37);
			this.idInput.Name = "idInput";
			this.idInput.Size = new System.Drawing.Size(136, 20);
			this.idInput.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Name:";
			// 
			// nameInput
			// 
			this.nameInput.Location = new System.Drawing.Point(77, 74);
			this.nameInput.Name = "nameInput";
			this.nameInput.Size = new System.Drawing.Size(136, 20);
			this.nameInput.TabIndex = 1;
			// 
			// agreeBtn
			// 
			this.agreeBtn.Location = new System.Drawing.Point(138, 110);
			this.agreeBtn.Name = "agreeBtn";
			this.agreeBtn.Size = new System.Drawing.Size(75, 23);
			this.agreeBtn.TabIndex = 2;
			this.agreeBtn.Text = "Agree";
			this.agreeBtn.UseVisualStyleBackColor = true;
			this.agreeBtn.Click += new System.EventHandler(this.agreeBtn_Click);
			// 
			// categoryEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(467, 282);
			this.Controls.Add(this.agreeBtn);
			this.Controls.Add(this.nameInput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.idInput);
			this.Controls.Add(this.label1);
			this.Name = "categoryEdit";
			this.Text = "categoryEdit";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox idInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox nameInput;
		private System.Windows.Forms.Button agreeBtn;
	}
}