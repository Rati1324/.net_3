using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Lesson10.Classes;
using Lesson10.FORMS;
using Lesson10.ENUMS;

namespace Lesson10 {
	public partial class Form1 : Form
    {
        NWDBEntities1 db = new NWDBEntities1();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                var result = db.Products.Select(i => new 
                {                    
                    ProductID = i.ProductID,
                    ProductName=i.ProductName,
                    Category = i.Category.CategoryName,
                    CategoryIcon = i.Category.Picture,
                    SupplierName = i.Supplier.CompanyName,
                    SupplierContact = i.Supplier.ContactName,
                    UnitPrice = i.UnitPrice,
                    UnitsInStock = i.UnitsInStock,
                    UnitsOnOrder = i.UnitsOnOrder,
                    QuantityPerUnit =i.QuantityPerUnit,                   
                    Discontinued=i.Discontinued,
                    ReorderLevel=i.ReorderLevel                   
                }).AsQueryable();

                if (string.IsNullOrEmpty(textBox_searhBy.Text))
                {
                    dataGridView_productList.DataSource = result.ToList();
                    textBox_Count.Text = result.Count().ToString();
                }

                else
                {
                    string keyWord = textBox_searhBy.Text;
                    var filtered = result.Where(i =>
                                                 i.ProductName.Contains(keyWord) ||
                                                 i.Category.Contains(keyWord) ||
                                                 i.SupplierName.Equals(keyWord)).ToList();
                    dataGridView_productList.DataSource = filtered;
                    textBox_Count.Text = filtered.Count().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void top3ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = db.Order_Details.GroupBy(i =>  new { i.ProductID, i.Product.ProductName })
                                             .Select(i => new Report { Name = i.Key.ProductName, Count = i.Count() })
                                             .OrderByDescending(i => i.Count).Take(3).ToList();               

                var report = new Report<Report> { Name = "Top 3 Products", Data = result };

                frmReports<Report> frm = new frmReports<Report>(report);
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void top3CategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = db.Products.GroupBy(i => new { i.CategoryID, i.Category.CategoryName })
                                             .Select(i => new Report { Name = i.Key.CategoryName, Count = i.Count() })
                                             .OrderByDescending(i => i.Count).Take(3).ToList();

                var report = new Report<Report> { Name = "Top 3 Categories", Data = result };

                frmReports<Report> frm = new frmReports<Report>(report);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void top3SuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = db.Products.GroupBy(i => new { i.SupplierID, i.Supplier.CompanyName })
                                             .Select(i => new Report { Name = i.Key.CompanyName, Count = i.Count() })
                                             .OrderByDescending(i => i.Count).Take(3).ToList();

                var report = new Report<Report> { Name = "Top 3 Suppliers", Data = result };

                frmReports<Report> frm = new frmReports<Report>(report);
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox_searhBy.Text = string.Empty;
            button_Search_Click(sender, e);
        }

        private void getAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var result = db.Categories.Select(i=> new CategoryDTO
                {
                    ID = i.CategoryID,
                    Name= i.CategoryName,
                    Description = i.Description,
                    Picture = i.Picture
                }).ToList();

                var report = new Report<CategoryDTO> { Name = "Category Full List", Data = result };

                frmReports<CategoryDTO> frm = new frmReports<CategoryDTO>(report);
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyCategory frm = new frmModifyCategory(ModeEnum.Add);
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyCategory frm = new frmModifyCategory(ModeEnum.Edit);
            frm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModifyCategory frm = new frmModifyCategory(ModeEnum.Delete);
            frm.Show();
        }

        private void dataGridView_productList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView_productList.SelectedRows[0];
                int productID = int.Parse(row.Cells[0].Value.ToString());

                if (MessageBox.Show("Do you want to remove this product from list?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                   
                    Product p = db.Products.Where(i => i.ProductID == productID).First();
                    db.Products.Remove(p);
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
