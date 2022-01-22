
namespace Lesson10.FORMS
{
    partial class frmModifyCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.pictureBox_Category = new System.Windows.Forms.PictureBox();
            this.button_Agreement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(544, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Upload Picture";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(186, 20);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(327, 39);
            this.textBox_ID.TabIndex = 2;
            this.textBox_ID.MouseLeave += new System.EventHandler(this.textBox_ID_MouseLeave);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(186, 61);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(327, 39);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Description.Location = new System.Drawing.Point(186, 117);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(327, 152);
            this.textBox_Description.TabIndex = 2;
            // 
            // pictureBox_Category
            // 
            this.pictureBox_Category.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Category.Location = new System.Drawing.Point(561, 20);
            this.pictureBox_Category.Name = "pictureBox_Category";
            this.pictureBox_Category.Size = new System.Drawing.Size(133, 128);
            this.pictureBox_Category.TabIndex = 3;
            this.pictureBox_Category.TabStop = false;         
            // 
            // button_Agreement
            // 
            this.button_Agreement.Location = new System.Drawing.Point(282, 295);
            this.button_Agreement.Name = "button_Agreement";
            this.button_Agreement.Size = new System.Drawing.Size(154, 54);
            this.button_Agreement.TabIndex = 4;
            this.button_Agreement.Text = "Agreement";
            this.button_Agreement.UseVisualStyleBackColor = true;
            this.button_Agreement.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModifyCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 376);
            this.Controls.Add(this.button_Agreement);
            this.Controls.Add(this.pictureBox_Category);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModifyCategory";
            this.Text = "frmAddOrUpdateCategory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.PictureBox pictureBox_Category;
        private System.Windows.Forms.Button button_Agreement;
    }
}