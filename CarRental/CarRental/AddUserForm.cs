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
		private int id;
		private User user = new User();
		string oldCountry;
		string oldCity;

		public AddUserForm(int id = 0) {
			InitializeComponent();
			if (id == 0) {
				saveBtn.Hide();
			} 
			else {
				this.id = id;
				populate();
			}

			var branches = db.Branch.Select(i => i.City1.name).ToList();
			foreach (var b in branches) {
				branchInput.Items.Add(b);
			}
			branchInput.SelectedIndex = 0;
		}

		private void addBtn_Click(object sender, EventArgs e) {
			var x = db.Address.Where(i => i.country == 1 && i.city == 1).ToList();
			this.user.f_name = fNameInput.Text;
			this.user.l_name = lNameInput.Text;
			this.user.personal_id = pIdInput.Text;
			this.user.email = emailInput.Text;
			this.user.phone = phoneInput.Text;
			this.user.dob = dobInput.Value;
			this.user.password = passwordInput.Text;
			this.user.type = 2;
			this.user.full_address = streetInput.Text;
			// This adds the address
			checkCityAndCountry();
			db.User.Add(this.user);
			db.SaveChanges();
		}
		
		private void saveBtn_Click(object sender, EventArgs e) {
			this.user.f_name = fNameInput.Text;
			this.user.l_name = lNameInput.Text;
			this.user.phone = phoneInput.Text;
			this.user.personal_id = pIdInput.Text;
			this.user.email = emailInput.Text;
			this.user.dob = dobInput.Value;
			this.user.password = passwordInput.Text;
			// This adds the address
			this.user.full_address = streetInput.Text;
			checkCityAndCountry();
			db.SaveChanges();
		}

		private void checkCityAndCountry() {
			var country = db.Country.Where(i => i.name == countryInput.Text).Select(i => new {
				id = i.id 
			}).ToList();
			var city = db.City.Where(i => i.name == cityInput.Text).Select(i => new {
				id = i.id 
			}).ToList();
			if (country.Count == 1 && city.Count == 1) {
				int cityId = city[0].id;
				int countryId = country[0].id;
				var a = db.Address.Where(i => i.city == cityId && i.country == countryId).ToList();
				if (a.Count == 1) {
					this.user.address = a[0].id;
				}
				this.user.address = insertAddress(country[0].id, city[0].id);
			}
			else if (country.Count == 1) {
				City c = new City { name = cityInput.Text };
				db.City.Add(c);
				db.SaveChanges();
				this.user.address = insertAddress(country[0].id, c.id);
			}
			else if (city.Count == 1) {
				Country c = new Country { name = countryInput.Text };
				db.Country.Add(c);
				db.SaveChanges();
				this.user.address = insertAddress(c.id, city[0].id);
			}
			else {
				Country co = new Country { name = countryInput.Text };
				City ci = new City { name = cityInput.Text };
				db.Country.Add(co);
				db.SaveChanges();
				db.City.Add(ci);
				db.SaveChanges();
				this.user.address = insertAddress(co.id, ci.id);
			}
		}

		private int insertAddress(int countryId, int cityId) {
			Address A = new Address { country = countryId, city = cityId };
			db.Address.Add(A);
			db.SaveChanges();
			return A.id;
		}

		private void populate() {
			this.user = db.User.Where(i => i.id == this.id).Select(u => u).First();
			fNameInput.Text = user.f_name;
			lNameInput.Text = user.l_name;
			phoneInput.Text = user.phone;
			pIdInput.Text = user.personal_id;
			emailInput.Text = user.email;
			dobInput.Value = (DateTime)user.dob;
			countryInput.Text = user.Address1.Country1.name;
			cityInput.Text = user.Address1.City1.name;
			streetInput.Text = user.full_address;
			passwordInput.Text = user.password;
			this.oldCountry = user.Address1.Country1.name;
			this.oldCity = user.Address1.City1.name;
		}

		private void backBtn_Click(object sender, EventArgs e) {
			this.Hide();
		}

	}
}
