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
			var branches = db.Branch.Select(i => new { id = i.id, name = i.City1.name }).ToList();
			branchInput.DisplayMember = "name";
			branchInput.ValueMember = "id";
			branchInput.DataSource = branches;
			if (id == 0) {
				saveBtn.Hide();
				branchInput.SelectedIndex = 0;
			} 
			else {
				this.id = id;
				//int index = db.Staff.findI
				populate();
			}
		}

		private void addBtn_Click(object sender, EventArgs e) {
			this.user.f_name = fNameInput.Text;
			this.user.l_name = lNameInput.Text;
			this.user.personal_id = pIdInput.Text;
			this.user.email = emailInput.Text;
			this.user.phone = phoneInput.Text;
			this.user.dob = dobInput.Value;
			this.user.password = passwordInput.Text;
			this.user.type = 2;
			this.user.full_address = streetInput.Text;
			checkCityAndCountry();
			db.User.Add(this.user);
			db.SaveChanges();
			Staff s = new Staff();
			s.branch = Int32.Parse(branchInput.SelectedValue.ToString());
			s.id = this.user.id;
			db.Staff.Add(s);
			db.SaveChanges();
		}
		
		public void saveBtn_Click(object sender, EventArgs e) {
			this.user.f_name = fNameInput.Text;
			this.user.l_name = lNameInput.Text;
			this.user.phone = phoneInput.Text;
			this.user.personal_id = pIdInput.Text;
			this.user.email = emailInput.Text;
			this.user.dob = dobInput.Value;
			this.user.password = passwordInput.Text;
			this.user.full_address = streetInput.Text;
			this.user.Staff.branch = Int32.Parse(branchInput.SelectedValue.ToString());
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
				this.user.address = city[0].id;
			}
			else if (country.Count == 1 && city.Count == 0) {
				City c = new City { name = cityInput.Text, country = country[0].id };
				db.City.Add(c);
				db.SaveChanges();
				this.user.address = c.id;
			}
			else {
				Country co = new Country { name = countryInput.Text };
				City ci = new City { name = cityInput.Text, country = co.id };
				db.Country.Add(co);
				db.City.Add(ci);
				db.SaveChanges();
				this.user.address = ci.id;
			}
		}

		private void populate() {
			this.user = db.User.Where(i => i.id == this.id).Select(u => u).First();
			fNameInput.Text = user.f_name;
			lNameInput.Text = user.l_name;
			phoneInput.Text = user.phone;
			pIdInput.Text = user.personal_id;
			emailInput.Text = user.email;
			dobInput.Value = (DateTime)user.dob;
			countryInput.Text = user.City.Country1.name;
			cityInput.Text = user.City.name;
			streetInput.Text = user.full_address;
			passwordInput.Text = user.password;
		}

		private void backBtn_Click(object sender, EventArgs e) {
			this.Hide();
		}

	}
}
