
namespace Lesson10
{
    partial class frmReports<T>
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
            this.dataGridView_report = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_report
            // 
            this.dataGridView_report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_report.Location = new System.Drawing.Point(12, 31);
            this.dataGridView_report.Name = "dataGridView_report";
            this.dataGridView_report.RowHeadersWidth = 62;
            this.dataGridView_report.RowTemplate.Height = 28;
            this.dataGridView_report.Size = new System.Drawing.Size(621, 222);
            this.dataGridView_report.TabIndex = 0;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 265);
            this.Controls.Add(this.dataGridView_report);
            this.Name = "frmReports";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_report)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_report;
    }
}