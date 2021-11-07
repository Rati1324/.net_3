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

		public DataTable GetAuthors(int bookId)
		{
			DataTable Authors = GetData($"select_authors {bookId}");
			return Authors;
		}

		public override DataTable GetInfo()
		{
			// Use parameterized procedures
			DataTable publicationData = base.GetInfo();
			DataTable bookData = base.GetData("select_book");
		
			for (int i = 1; i < bookData.Columns.Count; i++)
			{
				publicationData.Columns.Add(bookData.Columns[i].ColumnName);
			}
			publicationData.Columns.Add("Authors");

			DataTable Authors;
			for (int i = 0; i < publicationData.Rows.Count; i++)
			{
				Authors = GetAuthors((int)bookData.Rows[i]["id"]);

				publicationData.Rows[i]["Pages"] = bookData.Rows[i]["Pages"];
				publicationData.Rows[i]["Publisher name"] = bookData.Rows[i]["Publisher name"];

				foreach (DataRow row in Authors.Rows)
				{
					publicationData.Rows[i]["Authors"] += row["f_name"] + " " + row["l_name"] + ", ";
				}
			}
			return publicationData;
		}
	}
}
