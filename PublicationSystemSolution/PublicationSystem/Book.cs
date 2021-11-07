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
			DataTable Data = base.GetInfo();
			DataTable Data2 = base.GetData("select_book");

			foreach (DataColumn col in Data2.Columns)
			{
				//Data2.Columns[0].ColumnName;
				Data.Columns.Add(col.ColumnName = char.ToUpper(col.ColumnName[0]) + col.ColumnName.Substring(1, col.ColumnName.Length - 1));
;
			}
			return Data2;
		}
	}
}
