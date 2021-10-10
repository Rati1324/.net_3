using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12
{
	public class User
	{
		private int ID;
		public string FirstName;
		public string LastName;
		private string PersonalNumber;
		private DateTime? BirthDate;
		private int GenderID;
		private string PhoneNumber;
		private string EMail;
		private int RoleID;
		
		public User(int ID, string FirstName, string PersonalNumber, DateTime? BirthDate, 
			int GenderID, string PhoneNumber, string EMail, int RoleID)
		{
			this.ID = ID; this.FirstName = FirstName; this.PersonalNumber = PersonalNumber;
			this.BirthDate = BirthDate; this.GenderID = GenderID; this.PhoneNumber = PhoneNumber;
			this.EMail = EMail; this.RoleID = RoleID;
		}
		
	}
}
