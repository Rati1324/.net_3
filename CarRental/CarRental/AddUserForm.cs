using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental {
	public partial class AddUserForm : Form {
		CarRentalEntities db = new CarRentalEntities();
		private string email;

		public AddUserForm(string email = "") {
			this.email = email;
			InitializeComponent();
		}

		private void addBtn_Click(object sender, EventArgs e) {
			string fName = fNameInput.Text;
			string lName = lNameInput.Text;
			string personalId = pIdInput.Text;
			string eMail = emailInput.Text;
			string phone = phoneInput.Text;
			DateTime dob = dobInput.Value;
			string password = passwordInput.Text;
			string userCountry = countryInput.Text;
			string userCity = cityInput.Text;
			string userStreet = streetInput.Text;
			Address A = new Address();

			var country = db.Country.Where(i => i.name == userCountry).Select(i => new {
				id = i.id 
			}).ToList();
			if (country.Count == 1) {
				A.country = country[0].id;
			} 
			else {
				Country C = new Country {name = userCountry};
				db.Country.Add(C);
				db.SaveChanges();
				A.country = C.id;
			}

			var city = db.City.Where(i => i.name == userCity).Select(i => new {
				id = i.id 
			}).ToList();
			if (city.Count == 1) {
				A.city = city[0].id;
			} 
			else {
				City C = new City {name = userCity};
				db.City.Add(C);
				db.SaveChanges();
				A.city = C.id;
			}

			A.street = userStreet;
			db.Address.Add(A);
			User U = new User {
				f_name = fName,
				l_name = lName,
				personal_id = personalId,
				email = eMail,
				phone = phone,
				dob = dob,
				password = password,
				address = A.id,
				type = 2
			};
			db.User.Add(U);
			db.SaveChanges();
		}

		public void populate(string email) {
			emailInput.Text = email;
		}
		private void backBtn_Click(object sender, EventArgs e) {
			this.Hide();
		}
	}
}
