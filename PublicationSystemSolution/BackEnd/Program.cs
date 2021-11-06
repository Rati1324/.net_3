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
							SqlCommand testQuery = new SqlCommand("Insert into book values(sds,2,3,1999-2-)", conn, tran);

							SqlCommand comBook = new SqlCommand("insert_book", conn, tran);
							comBook.CommandType = CommandType.StoredProcedure;
							SqlParameter param1 = comBook.Parameters.Add("@name", SqlDbType.NVarChar);
							param1.Value = name;
							SqlParameter param2 = comBook.Parameters.Add("@pages", SqlDbType.Int);
							param2.Value = pages;
							SqlParameter param3 = comBook.Parameters.Add("@publisher_id", SqlDbType.Int);
							param3.Value = publisher;
							SqlParameter param4 = comBook.Parameters.Add("@pub_date", SqlDbType.Date);
							param4.Value = date;
							Console.WriteLine("fuck");
							bookId = (int)comBook.ExecuteScalar();
							throw new Exception("fuck you");
							tran.Commit();
						}

						// Inserting author
						//checkQuery = $"IF EXISTS (SELECT id FROM author WHERE f_name='{f_name}' AND l_name='{l_name}') SELECT 1 ELSE SELECT 0"
						//exists = (int)new SqlCommand()
						//com.CommandType = CommandType.StoredProcedure;
						//SqlParameter param1 = com.Parameters.AddWithValue("@name", SqlDbType.NVarChar);
						//param1.Value = name;
						//SqlParameter param2 = com.Parameters.AddWithValue("@pages", SqlDbType.Int);
						//param2.Value = pages;
						//SqlParameter param3 = com.Parameters.AddWithValue("@publisher_id", SqlDbType.Int);
						//param3.Value = publisher;
						//SqlParameter param4 = com.Parameters.AddWithValue("@pub_date", SqlDbType.Date);
						//param4.Value = date;
						//com.ExecuteScalar();
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
