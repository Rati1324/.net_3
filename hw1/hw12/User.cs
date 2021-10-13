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
		private int? id;
		public string FirstName;
		public string LastName;
		private string personalNumber;
		private DateTime? birthDate;
		private int genderID;
		private string phoneNumber;
		private string eMail;
		private int roleID;
		private DB db = new DB();
		
		public User(int? id, string FirstName, string LastName, string personalNumber, DateTime? birthDate, 
			int genderID, string phoneNumber, string eMail, int roleID)
		{
			this.id = id; this.FirstName = FirstName; this.LastName = LastName;
			this.personalNumber = personalNumber; this.birthDate = birthDate;
			this.genderID = genderID; this.phoneNumber = phoneNumber;
			this.eMail = eMail; this.roleID = roleID;
		}
		
		public void Insert()
		{
			//return this.birthDate.Value.ToString("yyyy-MM-dd");
			var date = this.birthDate.Value.ToString("yyyy-MM-dd");
			string query = $"INSERT INTO Users VALUES('{this.FirstName}', '{this.LastName}'," +
				$"'{this.personalNumber}', '{date}', " +
				$"{this.genderID}, '{this.phoneNumber}', '{this.eMail}', {this.roleID})";
			this.db.Execute(query);
		}


		public void Update()
		{
			var date = this.birthDate.Value.ToString("dd.MM.yyyy");
			string query = $"UPDATE Users SET FirstName='{this.FirstName}', LastName='{this.LastName}', birthDate='{date}'," +
				$"genderID={this.genderID}, phoneNumber='{this.phoneNumber}', eMail='{this.eMail}', roleID='{this.roleID}' WHERE id={this.id}";
			this.db.Execute(query);
		}

		public void Delete()
		{
			string query = $"DELETE from Users WHERE id = {this.id}";
			this.db.Execute(query);
		}
	}
}
