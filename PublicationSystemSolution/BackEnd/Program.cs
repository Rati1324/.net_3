using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace BackEnd
{
	class Program
	{
		public static void insert(ArrayList data, string procedure)
		{

		}
		static void Main(string[] args)
		{
			string name = "book2";
			int pages = 200;
			int publisher = 2;
			DateTime date = new DateTime(2010, 1, 2);
			string f_name = "jack";
			string l_name = "jackson";
			
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
						string checkQuery = $"IF EXISTS (SELECT id FROM book WHERE name='{name}') SELECT 1 ELSE SELECT 0";
						int exists = (int)new SqlCommand(checkQuery, conn, tran).ExecuteScalar();
						if (exists > 0)
						{
							bookId = (int)new SqlCommand($"SELECT TOP(1) id FROM author WHERE f_name='{f_name}' AND l_name='{l_name}'", conn, tran).ExecuteScalar();
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
							bookParam3.Value = publisher;
							SqlParameter bookParam4 = comBook.Parameters.Add("@pub_date", SqlDbType.Date);
							bookParam4.Value = date;
							Console.WriteLine("fuck");
							bookId = (int)comBook.ExecuteScalar();
						}

						// Inserting author. I'm not checking for already existing rows maybe add that later!
						int authorId;
						SqlCommand comAuthor = new SqlCommand("insert_author", conn, tran);
						comAuthor.CommandType = CommandType.StoredProcedure;
						SqlParameter authorParam1 = comAuthor.Parameters.AddWithValue("@f_name", SqlDbType.NVarChar);
						authorParam1.Value = f_name;
						SqlParameter authorParam2 = comAuthor.Parameters.AddWithValue("@l_name", SqlDbType.NVarChar);
						authorParam2.Value = l_name;
						authorId = (int)comAuthor.ExecuteScalar();

						// Inserting author_book
						SqlCommand comAuthorBook = new SqlCommand("insert_author_book", conn, tran);
						comAuthorBook.CommandType = CommandType.StoredProcedure;
						SqlParameter authorBookParam1 = comAuthorBook.Parameters.AddWithValue("@author_id", SqlDbType.NVarChar);
						authorBookParam1.Value = authorId;
						SqlParameter authorBookParam2 = comAuthorBook.Parameters.AddWithValue("@book_id", SqlDbType.NVarChar);
						authorBookParam2.Value = bookId;
						Console.WriteLine(authorId);
						Console.WriteLine(bookId);

						// Works but cant do it twice with same book
						comAuthorBook.ExecuteNonQuery();

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
	}
}
