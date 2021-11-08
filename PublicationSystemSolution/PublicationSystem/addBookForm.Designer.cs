
namespace PublicationSystem
{
	partial class addBookForm
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
			this.bNameInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.bAuthorsInput = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.bDateInput = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.bPubInput = new System.Windows.Forms.TextBox();
			this.bPagesInput = new System.Windows.Forms.TextBox();
			this.Pages = new System.Windows.Forms.Label();
			this.bRegButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// bNameInput
			// 
			this.bNameInput.Location = new System.Drawing.Point(125, 52);
			this.bNameInput.Name = "bNameInput";
			this.bNameInput.Size = new System.Drawing.Size(196, 20);
			this.bNameInput.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(66, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// bAuthorsInput
			// 
			this.bAuthorsInput.Location = new System.Drawing.Point(125, 89);
			this.bAuthorsInput.Name = "bAuthorsInput";
			this.bAuthorsInput.Size = new System.Drawing.Size(196, 20);
			this.bAuthorsInput.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(66, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Authors";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(327, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(198, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Separate them by a comma and a space";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(66, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(30, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Date";
			// 
			// bDateInput
			// 
			this.bDateInput.Location = new System.Drawing.Point(125, 124);
			this.bDateInput.Name = "bDateInput";
			this.bDateInput.Size = new System.Drawing.Size(196, 20);
			this.bDateInput.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(66, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Publisher";
			// 
			// bPubInput
			// 
			this.bPubInput.Location = new System.Drawing.Point(125, 159);
			this.bPubInput.Name = "bPubInput";
			this.bPubInput.Size = new System.Drawing.Size(196, 20);
			this.bPubInput.TabIndex = 0;
			// 
			// bPagesInput
			// 
			this.bPagesInput.Location = new System.Drawing.Point(125, 198);
			this.bPagesInput.Name = "bPagesInput";
			this.bPagesInput.Size = new System.Drawing.Size(196, 20);
			this.bPagesInput.TabIndex = 0;
			// 
			// Pages
			// 
			this.Pages.AutoSize = true;
			this.Pages.Location = new System.Drawing.Point(66, 201);
			this.Pages.Name = "Pages";
			this.Pages.Size = new System.Drawing.Size(37, 13);
			this.Pages.TabIndex = 1;
			this.Pages.Text = "Pages";
			// 
			// bRegButton
			// 
			this.bRegButton.Location = new System.Drawing.Point(246, 247);
			this.bRegButton.Name = "bRegButton";
			this.bRegButton.Size = new System.Drawing.Size(75, 23);
			this.bRegButton.TabIndex = 3;
			this.bRegButton.Text = "Register";
			this.bRegButton.UseVisualStyleBackColor = true;
			this.bRegButton.Click += new System.EventHandler(this.bRegButton_Click);
			// 
			// addBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bRegButton);
			this.Controls.Add(this.bDateInput);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Pages);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bAuthorsInput);
			this.Controls.Add(this.bPagesInput);
			this.Controls.Add(this.bPubInput);
			this.Controls.Add(this.bNameInput);
			this.Name = "addBookForm";
			this.Text = "addBookForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox bNameInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox bAuthorsInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker bDateInput;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox bPubInput;
		private System.Windows.Forms.TextBox bPagesInput;
		private System.Windows.Forms.Label Pages;
		private System.Windows.Forms.Button bRegButton;
	}
}