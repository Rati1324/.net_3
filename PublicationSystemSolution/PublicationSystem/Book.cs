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

		public string test2()
		{
			return "asd";
		}
		public override DataTable GetInfo()
		{
			DataTable Data = base.GetInfo();
			return Data;
		}
	}
}
