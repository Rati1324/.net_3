using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp {
	class Program {

		static void selectData() {
			EduDBEntities db = new EduDBEntities();
			var users = db.Users.Select(i =>
			new UserDTO {
				BirthDate = i.BirthDate,
				EMail = i.EMail,
				FullName = i.FirstName + " " + i.LastName,
				Gender = i.Gender.NameEN,
				Role = i.
				
				Role.NameEN,
				PersonalNumber = i.PersonalNumber,
				PhoneNumber = i.PhoneNumber
			}).Where(i => i.EMail == "8").ToList();

			//foreach (var item in users) {
			//	Console.WriteLine(item.PhoneNumber);
			//}
		}

		static void insertData() {
			try {
				EduDBEntities db = new EduDBEntities();
				User User = new User();
				User.FirstName = "John";
				User.LastName = "Johnson";
				User.PersonalNumber = "102910281";
				User.BirthDate = DateTime.Now;
				User.GenderID = 1;
				User.PhoneNumber = "3921042";
				User.EMail = "John@gmail.com";
				User.RoleID = 1;
				db.Users.Add(User);
				db.SaveChanges();

			} catch (Exception ex) {
				Console.WriteLine(ex.Message);
			}
		}
		
		static void updateData() {
			EduDBEntities db = new EduDBEntities();
			User user = db.Users.Where(i => i.FirstName.Equals("John")).First();
			user.EMail = "johnatan@gmail.com";
			db.SaveChanges();
		}

		static void Main(string[] args) {

		}
	}
}
