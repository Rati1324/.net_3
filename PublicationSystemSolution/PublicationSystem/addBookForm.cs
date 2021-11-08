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
		public addBookForm()
		{
			InitializeComponent();
		}

		private void bRegButton_Click(object sender, EventArgs e)
		{

			//string name = bNameInput.Text;
			//int pages = Int32.Parse(bPagesInput.Text);
			//string publisher = bPubInput.Text;
			//DateTime date = Convert.ToDateTime(bDateInput.Text);
			// This only works for one author, we need to parse the author field into an array
			// AUTHORS ARRAY HERE 
			ArrayList authorsList = new ArrayList() { new string[] { "Nick", "Nickson" }, new string[] { "Mari", "Maridze2" } };
			string name = "book12";
			int pages = 200;
			string publisher = "publisher30";
			DateTime date = new DateTime(2010, 1, 2);

			// Checking for already existing rows is stupid??
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString))
			{
				conn.Open();
				using (SqlTransaction tran = conn.BeginTransaction())
				{
					try
					{
						// Inserting book
						int bookId;
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
							// add the publisher
							publisherId = new SqlCommand($"INSERT INTO publisher VALUES('{publisher}')", conn, tran).ExecuteNonQuery();
						}
						string checkQuery = $"IF EXISTS (SELECT id FROM book WHERE name='{name}') SELECT 1 ELSE SELECT 0";
						exists = (int)new SqlCommand(checkQuery, conn, tran).ExecuteScalar();

						// This doesn't work need to check later
						if (exists > 0)
						{
							//bookId = (int)new SqlCommand($"SELECT TOP(1) id FROM author WHERE f_name='{f_name}' AND l_name='{l_name}'", conn, tran).ExecuteScalar();
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

						// Inserting author. I'm not checking for already existing rows maybe add that later!
						SqlCommand comAuthors;
						foreach (string[] a in authorsList)
						{
							comAuthors = new SqlCommand("insert_author", conn, tran);
							comAuthors.CommandType = CommandType.StoredProcedure;
							SqlParameter authorsParam1 = comAuthors.Parameters.AddWithValue("f_name", SqlDbType.NVarChar);
							authorsParam1.Value = a[0];
							SqlParameter authorsParam2 = comAuthors.Parameters.AddWithValue("l_name", SqlDbType.NVarChar);
							authorsParam2.Value = a[1];
							comAuthors.ExecuteNonQuery();
						}
						// Inserting publisher
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
