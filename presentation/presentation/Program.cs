using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Configuration;

namespace presentation
{
	class Program
	{
		public static DataTable CreateDataAdapter(string providerName, string connectionString)
		{
			try
			{
				DbProviderFactory factory = DbProviderFactories.GetFactory(providerName);
				// Create Connection
				DbConnection conn = factory.CreateConnection();
				conn.ConnectionString = connectionString;

				using (conn)
				{
					string queryString = "SELECT * FROM Users";

					// Create te DbCommand
					DbCommand command = factory.CreateCommand();
					command.CommandText = queryString;
					command.Connection = conn;

					// Create the DbDataAdapter
					DbDataAdapter adapter = factory.CreateDataAdapter();
					adapter.SelectCommand = command;

					// Fill the DataTable.
					DataTable table = new DataTable();
					adapter.Fill(table);
					return table;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return null; 
			}
		}

		static void accessDb()
		{
			string connString = ConfigurationManager.ConnectionStrings["AccessDb"].ConnectionString;
			string query = "SELECT * FROM Users";
			OleDbConnection conn = new OleDbConnection(connString);
			conn.Open();
			OleDbCommand com = new OleDbCommand(query, conn);
			OleDbDataAdapter ad = new OleDbDataAdapter(com);
		}
		
		static void Main(string[] args)
		{
			//accessDb();
			string providerName = ConfigurationManager.ConnectionStrings["AccessDb"].ProviderName;
			string connString = ConfigurationManager.ConnectionStrings["AccessDb"].ConnectionString;
			//DataTable table = new DataTable();
			DataTable table = CreateDataAdapter(providerName, connString);
			foreach (DataRow row in table.Rows)
			{
				foreach (DataColumn col in table.Columns)
				{
					Console.WriteLine(row[col]);
				}
			}
		}
	}
}
