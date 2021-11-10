using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicationSystem
{
	public partial class Form1 : Form
	{
		public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString);
		public Form1()
		{
			InitializeComponent();
			searchBy.DropDownStyle = ComboBoxStyle.DropDownList;
			searchBy.Items.Add("Date range");
			searchBy.Items.Add("Top m");
			searchBy.SelectedIndex = 0;
		}

		private void getBooks_Click(object sender, EventArgs e)
		{
			Book B = new Book();
			B.GetInfo();
			DataTable bookData = B.GetInfo();
			dataGrid.DataSource = bookData;
			dataGrid.Columns["id"].Visible = false;
		}

		private void addBookBtn_Click(object sender, EventArgs e)
		{
			addBookForm bookForm = new addBookForm();
			bookForm.Show();
		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			DataGridViewRow Row = dataGrid.SelectedRows[0];
			addBookForm bookForm = new addBookForm();
			bookForm.fillInputs(Row);
			bookForm.Show();
		}

		private void bDeleteBtn_Click(object sender, EventArgs e)
		{
			conn.Open();
			int BookId = Int32.Parse(dataGrid.SelectedRows[0].Cells[2].Value.ToString());
			string query = $"DELETE FROM author_book WHERE book_id={BookId}; DELETE FROM book WHERE id={BookId}";
			SqlCommand com = new SqlCommand(query, conn);
			com.Parameters.AddWithValue("@BookID", BookId);
			com.ExecuteNonQuery();
		}

		private void searchBtn_Click(object sender, EventArgs e)
		{
			if (searchBy.SelectedIndex == 0)
			{
				string from = datePicker1.Value.ToString("yyyy-MM-dd");
				string to = datePicker2.Value.ToString("yyyy-MM-dd");
				string query = $"SELECT * FROM BOOK WHERE pub_date<'{from}' AND pub_date>'{to}'";
			}
		}

		private void searchBy_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (searchBy.SelectedIndex == 0)
			{
				datePicker1.Show();
				datePicker2.Show();
				searchBox.Hide();
			}
			else
			{
				searchBox.Show();
				datePicker1.Hide();
				datePicker2.Hide();
			}
		}
	}
}
