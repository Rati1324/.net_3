using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12
{
	public class User
	{
		public int? Id;
		public string FirstName;
		public string LastName;
		public string PersonalNumber;
		public DateTime? BirthDate;
		public int GenderID;
		public string PhoneNumber;
		public string EMail;
		public int RoleID;
		
	}
}
