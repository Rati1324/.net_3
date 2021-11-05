using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BackEnd
{
	class Program
	{
		static void Main(string[] args)
		{
			// Insert book into the database
			string name = "book1";
			int pages = 200;
			int publisher = 2;
			DateTime date = new DateTime(2010, 1, 2);
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString))
			{
				using (SqlCommand com = new SqlCommand("insert_book", conn))
				{
					conn.Open();
					try
					{
						com.CommandType = CommandType.StoredProcedure;
						SqlParameter param1 = com.Parameters.AddWithValue("@name", SqlDbType.NVarChar);
						param1.Value = name;
						SqlParameter param2 = com.Parameters.AddWithValue("@pages", SqlDbType.Int);
						param2.Value = pages;
						SqlParameter param3 = com.Parameters.AddWithValue("@publisher_id", SqlDbType.Int);
						param3.Value = publisher;
						SqlParameter param4 = com.Parameters.AddWithValue("@pub_date", SqlDbType.Date);
						param4.Value = date;
						com.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						throw new Exception(ex.Message);
					}
				}
			}

		}
	}
}
