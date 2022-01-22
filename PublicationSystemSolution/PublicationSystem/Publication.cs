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
	public abstract class Publication: Form1
	{
		public string Name { set; get; }
		public DateTime Date { set; get; }
		public ArrayList Authors { set; get; }

		public virtual DataTable GetInfo()
		{
			DataTable Data; 
			Data = DB.SelectData("SELECT name 'Name', pub_date 'Date' FROM book");
			return Data;
		}
	}
}
