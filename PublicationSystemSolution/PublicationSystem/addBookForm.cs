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
	public partial class addBookForm : Form
	{
		public int bookId;
		public string Name;
		public string Authors;
		public string Publisher;
		public DateTime Date;
		public int bookPages;
		public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString);

		public addBookForm()
		{
			InitializeComponent();
			bSaveButton.Hide();
		}

		// Register new book
		private void bRegButton_Click(object sender, EventArgs e)
		{
			string name = bNameInput.Text;
			int pages = Int32.Parse(bPagesInput.Text);
			string publisher = bPubInput.Text;
			DateTime date = Convert.ToDateTime(bDateInput.Text);

			string authorsString = bAuthorsInput.Text;
			string[] authorsList = authorsString.Split(new string[] { ", " }, StringSplitOptions.None);

			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString))
			{
				conn.Open();
				using (SqlTransaction tran = conn.BeginTransaction())
				{
					try
					{
						int bookId;
						int authorId = 0;

						// Inserting publisher
						int publisherId;
						string checkPubQuery = $"SELECT ISNULL((SELECT id from publisher WHERE name='{publisher}'), 0)";
						int exists = (int) new SqlCommand(checkPubQuery, conn, tran).ExecuteScalar();

						// Check if publisher exists
						if (exists != 0)
						{
							publisherId = exists;
						}
						else
						{
							SqlCommand comPub = new SqlCommand("insert_publisher", conn, tran);
							comPub.CommandType = CommandType.StoredProcedure;
							SqlParameter pubParam1 = comPub.Parameters.Add("@name", SqlDbType.NVarChar);
							pubParam1.Value = publisher;
							publisherId = (int)comPub.ExecuteScalar();
						}

						// Inserting book
						string checkBookQuery = $"SELECT ISNULL((SELECT id from book WHERE name='{name}'), 0)";
						bookId = (int)new SqlCommand(checkBookQuery, conn, tran).ExecuteScalar();

						if (bookId > 0)
						{
							bookId = (int)new SqlCommand($"SELECT TOP(1) id from book WHERE name='{name}'", conn, tran).ExecuteScalar();
							MessageBox.Show("Book already exists");
						}
						else
						{
							SqlCommand comBook = new SqlCommand("insert_book", conn, tran);
							comBook.CommandType = CommandType.StoredProcedure;
							SqlParameter bookParam1 = comBook.Parameters.Add("@name", SqlDbType.NVarChar);
							bookParam1.Value = name;
							SqlParameter bookParam2 = comBook.Parameters.Add("@pages", SqlDbType.Int);
							bookParam2.Value = pages;
							SqlParameter bookParam3 = comBook.Parameters.Add("@publisher_id", SqlDbType.Int);
							bookParam3.Value = publisherId;
							SqlParameter bookParam4 = comBook.Parameters.Add("@pub_date", SqlDbType.Date);
							bookParam4.Value = date;
							bookId = (int)comBook.ExecuteScalar();
						}

						// Inserting author
						SqlCommand comAuthors;
						SqlCommand comAuthorBook;
						string InsertAuthorQuery;
						string f_name, l_name;
						foreach (string a in authorsList)
						{
							string[] fullName = a.Split(new string[] { " " }, StringSplitOptions.None);
							f_name = fullName[0];
							l_name = fullName[1];
							authorId = DB.InsertAuthor(f_name, l_name);
							// Inserting author_book
							comAuthorBook = new SqlCommand("insert_author_book", conn, tran);
							comAuthorBook.CommandType = CommandType.StoredProcedure;
							SqlParameter authorBookParam1 = comAuthorBook.Parameters.AddWithValue("author_id", SqlDbType.Int);
							authorBookParam1.Value = authorId;

							SqlParameter authorBookParam2 = comAuthorBook.Parameters.AddWithValue("book_id", SqlDbType.Int);
							authorBookParam2.Value = bookId;
							comAuthorBook.ExecuteNonQuery();
						}
						tran.Commit();	
					}
					catch (Exception ex)
					{
						tran.Rollback();
						throw new Exception(ex.Message);
					}
				}
			}
		}

		// Update book
		private void bSaveButton_Click(object sender, EventArgs e)
		{
			string query;
			// put this in try except
			conn.Open();
			if (Name != bNameInput.Text)
			{
				try
				{
					query = $"UPDATE book SET name=@newName WHERE name=@oldName";
					SqlCommand com = new SqlCommand(query, conn);
					com.Parameters.AddWithValue("newName", bNameInput.Text);
					com.Parameters.AddWithValue("oldName", Name);
					com.ExecuteNonQuery();
					com.Dispose();
				}
				catch (Exception ex)
				{
					throw new Exception(ex.Message);
				}
			}

			if (Authors != bAuthorsInput.Text)
			{
				int authorId;
				string f_name;
				string l_name;
				string[] fullName;
				string[] authorsList = bAuthorsInput.Text.Split(new string[] { ", " }, StringSplitOptions.None);

				foreach (var a in authorsList)
				{
					fullName = a.Split(' ');
					f_name = fullName[0];
					l_name = fullName[1];

					// This inserts the author if exists, or returns the id
					authorId = DB.InsertAuthor(f_name, l_name);

					string query2 = $"SELECT ISNULL((SELECT 1 from author_book WHERE author_id=109 AND book_id=104), 0)";
					int InsertAuthorBook = (int)new SqlCommand(query2, conn).ExecuteScalar();

					// Inserting into autho_book table
					// if authorId == 0 that means the author already exists so im not doing   
					if (authorId == 0)
					{
						// maybe add deletion later
					}
					else
					{
						SqlCommand comAuthorBook = new SqlCommand("insert_author_book", conn);
						comAuthorBook.CommandType = CommandType.StoredProcedure;
						SqlParameter authorBookParam1 = comAuthorBook.Parameters.AddWithValue("author_id", SqlDbType.Int);
						authorBookParam1.Value = authorId;

						SqlParameter authorBookParam2 = comAuthorBook.Parameters.AddWithValue("book_id", SqlDbType.Int);
						authorBookParam2.Value = bookId;
						comAuthorBook.ExecuteNonQuery();
					}
				}
			}
		}

		// Fill inputs for update
		public void fillInputs(DataGridViewRow Row)
		{
			// name date pages pub authors 
			bRegButton.Hide();
			bSaveButton.Show();

			bNameInput.Text = Row.Cells[0].Value.ToString();
			Name = Row.Cells[0].Value.ToString();

			bDateInput.Value = Convert.ToDateTime(Row.Cells[1].Value);
			Date = Convert.ToDateTime(Row.Cells[1].Value);

			bookId = Int32.Parse(Row.Cells[2].Value.ToString());

			bPagesInput.Text = Row.Cells[3].Value.ToString();
			bookPages = Int32.Parse(Row.Cells[3].Value.ToString());

			bPubInput.Text = Row.Cells[4].Value.ToString();
			Publisher = Row.Cells[4].Value.ToString();

			bAuthorsInput.Text = Row.Cells[5].Value.ToString();
		}

	}
}
