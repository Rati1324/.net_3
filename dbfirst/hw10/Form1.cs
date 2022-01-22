using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw10 {
	public partial class Form1 : Form {
		NWDBEntities db = new NWDBEntities();
		public Form1() {
			InitializeComponent();
		}

		private void importBtn_Click(object sender, EventArgs e) {
			//var result = db.Products.GroupBy(i => i.CategoryID)
			//						.Select(i => new ProductReport { Name = i.Key.Cate})
			var result = from p in db.Products
						 where p.ProductName == "Chai"
						 select new { ProductName = p.ProductName, CategoryName = p.Category.CategoryName };
			//var result = db.Products.Where(j => j.ProductName == "Chai").Select(i => i.ProductName)
			productsGrid.DataSource = result.ToList();
		}

		private void searchBtn_Click(object sender, EventArgs e) {
			string keyword = searchInput.Text;
			var result = db.Products.Select(i => new {
				ProductName = i.ProductName,
				Category = i.Category.CategoryName
				}).AsQueryable();

			if (string.IsNullOrEmpty(keyword)) {
				productsGrid.DataSource = result.ToList();
			}
			else {
				var filtered = result.Where(i => i.ProductName.Contains(keyword));
				productsGrid.DataSource = filtered.ToList();
			}
		}

		private void categoryToolStripMenuItem1_Click(object sender, EventArgs e) {
			var result = db.Products.GroupBy(i => new { i.CategoryID, i.Category.CategoryName })
									.Select(i => new ProductReport { Name = i.Key.CategoryName, Count = i.Count() })
									.OrderByDescending(i => i.Count).Take(3).ToList();
			var report = new Report<ProductReport> { Name = "Top 3 Categories", Data = result };
			reportsForm<ProductReport> frm = new reportsForm<ProductReport>(report);
			frm.Show();
		}

		private void editToolStripMenuItem_Click(object sender, EventArgs e) {
			categoryEdit frm = new categoryEdit(Mode.Edit);
			frm.Show();
		}
	}
}
