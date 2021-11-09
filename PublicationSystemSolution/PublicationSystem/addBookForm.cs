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
							publisherId = (int) new SqlCommand($"insert_publisher '{publisher}'", conn, tran).ExecuteScalar();
						}

						// Inserting book
						string checkBookQuery = $"SELECT ISNULL((SELECT id from book WHERE name='{name}'), 0)";
						bookId = (int)new SqlCommand(checkBookQuery, conn, tran).ExecuteScalar();

						// This doesn't work need to check later
						if (bookId > 0)
						{
							bookId = (int)new SqlCommand($"SELECT TOP(1) id from book WHERE name='{name}'", conn, tran).ExecuteScalar();
						}

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

						// Inserting author
						SqlCommand comAuthors;
						SqlCommand comAuthorBook;
						string checkAuthorQuery;
						string f_name, l_name;
						foreach (string a in authorsList)
						{
							string[] fullName = a.Split(new string[] { " " }, StringSplitOptions.None);
							f_name = fullName[0];
							l_name = fullName[1];
							checkAuthorQuery = $"SELECT ISNULL((SELECT id from author WHERE f_name='{f_name}' AND l_name='{l_name}'), 0)";
							authorId = (int)new SqlCommand(checkAuthorQuery, conn, tran).ExecuteScalar();

							if (authorId == 0)
							{
								comAuthors = new SqlCommand("insert_author", conn, tran);
								comAuthors.CommandType = CommandType.StoredProcedure;
								SqlParameter authorsParam1 = comAuthors.Parameters.AddWithValue("f_name", SqlDbType.NVarChar);
								authorsParam1.Value = f_name;
								SqlParameter authorsParam2 = comAuthors.Parameters.AddWithValue("l_name", SqlDbType.NVarChar);
								authorsParam2.Value = l_name;
								authorId = (int)comAuthors.ExecuteScalar();
							}
							else
							{
								authorId = (int)new SqlCommand($"SELECT TOP(1) id from author WHERE f_name='{f_name}' AND l_name='{l_name}'", conn, tran).ExecuteScalar();
							}
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

			string authors = Row.Cells[5].Value.ToString();
			bAuthorsInput.Text = authors.Substring(0, authors.Length - 2);

		}

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
					authorId = DB.CheckAuthor(f_name, l_name, conn);

					string query2 = $"SELECT ISNULL((SELECT 1 from author_book WHERE author_id=109 AND book_id=104), 0)";
					int checkAuthorBook = (int)new SqlCommand(query2, conn).ExecuteNonQuery();

					MessageBox.Show(checkAuthorBook.ToString());
					SqlCommand comAuthorBook = new SqlCommand("insert_author_book", conn);
					comAuthorBook.CommandType = CommandType.StoredProcedure;
					SqlParameter authorBookParam1 = comAuthorBook.Parameters.AddWithValue("author_id", SqlDbType.Int);
					authorBookParam1.Value = authorId;

					SqlParameter authorBookParam2 = comAuthorBook.Parameters.AddWithValue("book_id", SqlDbType.Int);
					authorBookParam2.Value = bookId;
					//comAuthorBook.ExecuteNonQuery();
				}
			}
		}
	}
}
