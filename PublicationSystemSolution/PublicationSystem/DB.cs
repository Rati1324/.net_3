using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace PublicationSystem
{
	class DB
	{
		public static int CheckAuthor(string f_name, string l_name, SqlConnection conn)
		{
			string checkAuthorQuery = $"SELECT ISNULL((SELECT id from author WHERE f_name='{f_name}' AND l_name='{l_name}'), 0)";
			// This inserts a new author if, or returns  
			int authorId = (int)new SqlCommand(checkAuthorQuery, conn).ExecuteScalar();

			if (authorId == 0)
			{
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
			//else
			//{
			//	authorId = (int)new SqlCommand($"SELECT TOP(1) id from author WHERE f_name='{f_name}' AND l_name='{l_name}'", conn).ExecuteScalar();
			//}
			return authorId;
		}
	}
}
