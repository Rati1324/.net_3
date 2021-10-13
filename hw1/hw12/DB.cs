using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12
{
	public class DB
	{
		public void Execute(string query)
		{
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["edu"].ConnectionString))
			{
				using (SqlCommand com = new SqlCommand(query, conn))
				{
					conn.Open();
					try
					{
						com.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						throw new Exception($"error {ex}");
					}
				}
			}

		}
		public DataTable GetData(string query)

		{
			using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["edu"].ConnectionString);
			{
				using (SqlCommand com = new SqlCommand(query, conn))
				{
					conn.Open();
					SqlDataReader sdr = com.ExecuteReader();
					DataTable dt = new DataTable();
					dt.Load(sdr);
					return dt;
				}
			}
		}

	}
}
