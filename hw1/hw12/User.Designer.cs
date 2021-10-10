
namespace hw12
{
	partial class User
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
			this.components = new System.ComponentModel.Container();
			this.f_nameInput = new System.Windows.Forms.TextBox();
			this.l_nameInput = new System.Windows.Forms.TextBox();
			this.idInput = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dobInput = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.genderInput = new System.Windows.Forms.ComboBox();
			this.genderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.eduDBDataSet1 = new hw12.EduDBDataSet1();
			this.addBtn = new System.Windows.Forms.Button();
			this.eduDBDataSet = new hw12.EduDBDataSet();
			this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.genderTableAdapter = new hw12.EduDBDataSetTableAdapters.GenderTableAdapter();
			this.genderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.genderTableAdapter1 = new hw12.EduDBDataSet1TableAdapters.GenderTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.genderBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eduDBDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.eduDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// f_nameInput
			// 
			this.f_nameInput.Location = new System.Drawing.Point(117, 36);
			this.f_nameInput.Name = "f_nameInput";
			this.f_nameInput.Size = new System.Drawing.Size(189, 20);
			this.f_nameInput.TabIndex = 0;
			// 
			// l_nameInput
			// 
			this.l_nameInput.Location = new System.Drawing.Point(117, 74);
			this.l_nameInput.Name = "l_nameInput";
			this.l_nameInput.Size = new System.Drawing.Size(189, 20);
			this.l_nameInput.TabIndex = 1;
			// 
			// idInput
			// 
			this.idInput.Location = new System.Drawing.Point(117, 110);
			this.idInput.Name = "idInput";
			this.idInput.Size = new System.Drawing.Size(189, 20);
			this.idInput.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "First Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Last Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Id";
			// 
			// dobInput
			// 
			this.dobInput.Location = new System.Drawing.Point(117, 149);
			this.dobInput.Name = "dobInput";
			this.dobInput.Size = new System.Drawing.Size(200, 20);
			this.dobInput.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(47, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Date of Birth";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(47, 186);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(42, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Gender";
			// 
			// genderInput
			// 
			this.genderInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.genderInput.FormattingEnabled = true;
			this.genderInput.Location = new System.Drawing.Point(117, 183);
			this.genderInput.Name = "genderInput";
			this.genderInput.Size = new System.Drawing.Size(200, 21);
			this.genderInput.TabIndex = 5;
			// 
			// genderBindingSource2
			// 
			this.genderBindingSource2.DataMember = "Gender";
			this.genderBindingSource2.DataSource = this.eduDBDataSet1;
			// 
			// eduDBDataSet1
			// 
			this.eduDBDataSet1.DataSetName = "EduDBDataSet1";
			this.eduDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// addBtn
			// 
			this.addBtn.Location = new System.Drawing.Point(242, 221);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(75, 23);
			this.addBtn.TabIndex = 6;
			this.addBtn.Text = "Add";
			this.addBtn.UseVisualStyleBackColor = true;
			// 
			// eduDBDataSet
			// 
			this.eduDBDataSet.DataSetName = "EduDBDataSet";
			this.eduDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// genderBindingSource
			// 
			this.genderBindingSource.DataMember = "Gender";
			this.genderBindingSource.DataSource = this.eduDBDataSet;
			// 
			// genderTableAdapter
			// 
			this.genderTableAdapter.ClearBeforeFill = true;
			// 
			// genderBindingSource1
			// 
			this.genderBindingSource1.DataMember = "Gender";
			this.genderBindingSource1.DataSource = this.eduDBDataSet;
			// 
			// genderTableAdapter1
			// 
			this.genderTableAdapter1.ClearBeforeFill = true;
			// 
			// User
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.genderInput);
			this.Controls.Add(this.dobInput);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.idInput);
			this.Controls.Add(this.l_nameInput);
			this.Controls.Add(this.f_nameInput);
			this.Name = "User";
			this.Text = "Add new user";
			this.Load += new System.EventHandler(this.User_Load);
			((System.ComponentModel.ISupportInitialize)(this.genderBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eduDBDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.eduDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.genderBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox f_nameInput;
		private System.Windows.Forms.TextBox l_nameInput;
		private System.Windows.Forms.TextBox idInput;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dobInput;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox genderInput;
		private System.Windows.Forms.Button addBtn;
		private EduDBDataSet eduDBDataSet;
		private System.Windows.Forms.BindingSource genderBindingSource;
		private EduDBDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
		private System.Windows.Forms.BindingSource genderBindingSource1;
		private EduDBDataSet1 eduDBDataSet1;
		private System.Windows.Forms.BindingSource genderBindingSource2;
		private EduDBDataSet1TableAdapters.GenderTableAdapter genderTableAdapter1;
	}
}