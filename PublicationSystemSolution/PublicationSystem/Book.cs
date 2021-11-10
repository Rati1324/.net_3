using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicationSystem
{
	class Book: Publication
	{
		public int pages { set; get; }
		public string publisher { set; get; }

		public override DataTable GetInfo()
		{
			// Use parameterized procedures
			DataTable publicationData = base.GetInfo();
			DataTable bookData = DB.GetData("select_book");
			DataTable Authors;
		
			// This is for columns names
			for (int i = 0; i < bookData.Columns.Count; i++)
			{
				publicationData.Columns.Add(bookData.Columns[i].ColumnName);
			}
			publicationData.Columns.Add("Authors");

			// This is for the row of each book
			for (int i = 0; i < publicationData.Rows.Count; i++)
			{
				Authors = DB.GetData($"select_authors {(int)bookData.Rows[i]["id"]}");

				publicationData.Rows[i]["id"] = bookData.Rows[i]["id"]; 
				publicationData.Rows[i]["Pages"] = bookData.Rows[i]["Pages"];
				publicationData.Rows[i]["Publisher name"] = bookData.Rows[i]["Publisher name"];

				string comma = ", ";
				for (int j = 0; j < Authors.Rows.Count; j++)
				{
					if (j == Authors.Rows.Count - 1) comma = "";
					publicationData.Rows[i]["Authors"] += Authors.Rows[j]["f_name"] + " " + Authors.Rows[j]["l_name"] + comma;
				}
			}
			return publicationData;
		}
	}
}
