﻿using System;
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
		public addBookForm()
		{
			InitializeComponent();
		}

		private void bRegButton_Click(object sender, EventArgs e)
		{
			string name = bNameInput.Text;
			int pages = Int32.Parse(bPagesInput.Text);
			string publisher = bPubInput.Text;
			DateTime date = Convert.ToDateTime(bDateInput.Text);

			string authorsString = bAuthorsInput.Text;
			string[] authorsList = authorsString.Split(new string[] { ", " }, StringSplitOptions.None);
			// Checking for already existing rows is stupid??
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
			int cellIndex = 0;
			for (int i = 0; i < this.Controls.Count; i++)
			{
				var input = this.Controls[i] as TextBox;
				if (input != null)
				{
					MessageBox.Show(i.ToString());
					input.Text = Row.Cells[cellIndex].Value.ToString();
					cellIndex++;
				}
			}
		}

		// delete this
		private void button1_Click(object sender, EventArgs e)
		{
			ArrayList authorsList = new ArrayList()
			{
				new string[] { "Nick", "Nickson" },
				new string[] { "mari2", "maridze" }
			};
		}
	}
}
