using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12
{
	public class User
	{
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PersonalNumber { get; set; }
		public DateTime? BirthDate { get; set; }
		public int GenderID { get; set; }
		public string PhoneNumber { get; set; }
		public string EMail { get; set; }
		public int RoleID { get; set; }
	}
}
