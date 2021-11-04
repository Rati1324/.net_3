using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork
{
	public class Author
	{
		public string F_name { get; set; }
		public string L_name { get; set; }
		public DateTime Dob { get; set; }
		public List<Book> Books { get; set; }
	}

}
