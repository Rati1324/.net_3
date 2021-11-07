using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;

namespace PublicationSystem
{
	public abstract class Publication
	{
		public string Name { set; get; }
		public DateTime Date { set; get; }
		public ArrayList Authors { set; get; }

		public DataTable GetData(string query)
		{
			using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString);
			{
				using (SqlCommand com = new SqlCommand(query, conn))
				{
					try
					{
						conn.Open();
						SqlDataReader sdr = com.ExecuteReader();
						DataTable dt = new DataTable();
						dt.Load(sdr);
						return dt;
					}
					catch (Exception ex)
					{
						throw new Exception($"error {ex}");
					}
				}
			}
		}
		public virtual DataTable GetInfo()
		{
			DataTable Data; 
			Data = GetData("SELECT name, pub_date FROM book");
			return Data;
		}
	}
}
