﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace PublicationSystem
{
	class DB
	{
		public static int CheckAuthor(string f_name, string l_name)
		{
			using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString);
			string checkAuthorQuery = $"SELECT ISNULL((SELECT id from author WHERE f_name='{f_name}' AND l_name='{l_name}'), 0)";
			// This inserts a new author if, or returns  
			int authorId = (int)new SqlCommand(checkAuthorQuery, conn).ExecuteScalar();
			if (authorId == 0)
			{
				conn.Open();
				SqlCommand comAuthors = new SqlCommand("insert_author", conn);
				comAuthors.CommandType = CommandType.StoredProcedure;
				SqlParameter authorsParam1 = comAuthors.Parameters.AddWithValue("f_name", SqlDbType.NVarChar);
				authorsParam1.Value = f_name;
				SqlParameter authorsParam2 = comAuthors.Parameters.AddWithValue("l_name", SqlDbType.NVarChar);
				authorsParam2.Value = l_name;
				authorId = (int)comAuthors.ExecuteScalar();
			}
			else
			{
				authorId = 0;
			}
			return authorId;
		}
		public static DataTable GetData(string query)
		{
			using SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlDb"].ConnectionString);
			using SqlCommand com = new SqlCommand(query, conn);
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
