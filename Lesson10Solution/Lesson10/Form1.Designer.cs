
namespace Lesson10
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView_productList = new System.Windows.Forms.DataGridView();
            this.label_searchBy = new System.Windows.Forms.Label();
            this.textBox_searhBy = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top3ProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top3CategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top3SuppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_productList
            // 
            this.dataGridView_productList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_productList.Location = new System.Drawing.Point(12, 189);
            this.dataGridView_productList.MultiSelect = false;
            this.dataGridView_productList.Name = "dataGridView_productList";
            this.dataGridView_productList.RowHeadersWidth = 62;
            this.dataGridView_productList.RowTemplate.Height = 28;
            this.dataGridView_productList.Size = new System.Drawing.Size(990, 266);
            this.dataGridView_productList.TabIndex = 0;
            this.dataGridView_productList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_productList_RowEnter);
            // 
            // label_searchBy
            // 
            this.label_searchBy.AutoSize = true;
            this.label_searchBy.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_searchBy.Location = new System.Drawing.Point(12, 117);
            this.label_searchBy.Name = "label_searchBy";
            this.label_searchBy.Size = new System.Drawing.Size(122, 31);
            this.label_searchBy.TabIndex = 1;
            this.label_searchBy.Text = "Search By";
            // 
            // textBox_searhBy
            // 
            this.textBox_searhBy.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_searhBy.Location = new System.Drawing.Point(140, 114);
            this.textBox_searhBy.Name = "textBox_searhBy";
            this.textBox_searhBy.Size = new System.Drawing.Size(428, 39);
            this.textBox_searhBy.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriesToolStripMenuItem,
            this.produectsToolStripMenuItem,
            this.reportingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.getAllToolStripMenuItem});
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.categoriesToolStripMenuItem.Text = "Categories";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // getAllToolStripMenuItem
            // 
            this.getAllToolStripMenuItem.Name = "getAllToolStripMenuItem";
            this.getAllToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.getAllToolStripMenuItem.Text = "Get All";
            this.getAllToolStripMenuItem.Click += new System.EventHandler(this.getAllToolStripMenuItem_Click);
            // 
            // produectsToolStripMenuItem
            // 
            this.produectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.getAllToolStripMenuItem1});
            this.produectsToolStripMenuItem.Name = "produectsToolStripMenuItem";
            this.produectsToolStripMenuItem.Size = new System.Drawing.Size(107, 29);
            this.produectsToolStripMenuItem.Text = "Produects";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(166, 34);
            this.addToolStripMenuItem1.Text = "Add";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(166, 34);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(166, 34);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // getAllToolStripMenuItem1
            // 
            this.getAllToolStripMenuItem1.Name = "getAllToolStripMenuItem1";
            this.getAllToolStripMenuItem1.Size = new System.Drawing.Size(166, 34);
            this.getAllToolStripMenuItem1.Text = "Get All";
            this.getAllToolStripMenuItem1.Click += new System.EventHandler(this.getAllToolStripMenuItem1_Click);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.top3ProductsToolStripMenuItem,
            this.top3CategoriesToolStripMenuItem,
            this.top3SuppliersToolStripMenuItem});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.reportingToolStripMenuItem.Text = "Reporting";
            // 
            // top3ProductsToolStripMenuItem
            // 
            this.top3ProductsToolStripMenuItem.Name = "top3ProductsToolStripMenuItem";
            this.top3ProductsToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.top3ProductsToolStripMenuItem.Text = "Top 3 Products";
            this.top3ProductsToolStripMenuItem.Click += new System.EventHandler(this.top3ProductsToolStripMenuItem_Click);
            // 
            // top3CategoriesToolStripMenuItem
            // 
            this.top3CategoriesToolStripMenuItem.Name = "top3CategoriesToolStripMenuItem";
            this.top3CategoriesToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.top3CategoriesToolStripMenuItem.Text = "Top 3 Categories";
            this.top3CategoriesToolStripMenuItem.Click += new System.EventHandler(this.top3CategoriesToolStripMenuItem_Click);
            // 
            // top3SuppliersToolStripMenuItem
            // 
            this.top3SuppliersToolStripMenuItem.Name = "top3SuppliersToolStripMenuItem";
            this.top3SuppliersToolStripMenuItem.Size = new System.Drawing.Size(247, 34);
            this.top3SuppliersToolStripMenuItem.Text = "Top 3 Suppliers";
            this.top3SuppliersToolStripMenuItem.Click += new System.EventHandler(this.top3SuppliersToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Count:";
            // 
            // textBox_Count
            // 
            this.textBox_Count.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_Count.Location = new System.Drawing.Point(76, 474);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.ReadOnly = true;
            this.textBox_Count.Size = new System.Drawing.Size(100, 26);
            this.textBox_Count.TabIndex = 6;
            // 
            // button_Search
            // 
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Image = global::Lesson10.Properties.Resources.Ampeross_Qetto_2_Search;
            this.button_Search.Location = new System.Drawing.Point(572, 99);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(82, 64);
            this.button_Search.TabIndex = 3;
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCategoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(263, 69);
            // 
            // deleteCategoryToolStripMenuItem
            // 
            this.deleteCategoryToolStripMenuItem.CheckOnClick = true;
            this.deleteCategoryToolStripMenuItem.DoubleClickEnabled = true;
            this.deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            this.deleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(262, 32);
            this.deleteCategoryToolStripMenuItem.Tag = "Delete selected product";
            this.deleteCategoryToolStripMenuItem.Text = "delete product";
            this.deleteCategoryToolStripMenuItem.Click += new System.EventHandler(this.deleteCategoryToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 506);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_searhBy);
            this.Controls.Add(this.label_searchBy);
            this.Controls.Add(this.dataGridView_productList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Product Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_productList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_productList;
        private System.Windows.Forms.Label label_searchBy;
        private System.Windows.Forms.TextBox textBox_searhBy;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top3ProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top3CategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top3SuppliersToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryToolStripMenuItem;
    }
}

