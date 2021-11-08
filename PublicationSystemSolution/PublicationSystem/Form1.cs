using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicationSystem
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			//dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void getBooks_Click(object sender, EventArgs e)
		{
			Book B = new Book();
			B.GetInfo();
			DataTable bookData = B.GetInfo();
			dataGrid.DataSource = bookData;
		}

		private void addBookBtn_Click(object sender, EventArgs e)
		{
			addBookForm bookForm = new addBookForm();
			bookForm.Show();
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			int index = dataGrid.SelectedRows[0].Index;
			MessageBox.Show(index.ToString());
			DataGridViewRow Row = dataGrid.Rows[0];

			addBookForm bookForm = new addBookForm();
			bookForm.fillInputs(Row);
			bookForm.Show();
			
		}
	}
}
