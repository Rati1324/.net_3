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
	public partial class MainForm : Form {
		private CarRentalEntities db = new CarRentalEntities();
		private User user = new User();

		public MainForm() {
			InitializeComponent();
		}

		private void registerBtn_Click(object sender, EventArgs e) {
			this.user.f_name = fNameInput.Text;
			this.user.l_name = lNameInput.Text;
			this.user.phone = phoneInput.Text;
			this.user.personal_id = pIdInput.Text;
			this.user.email = emailInput.Text;
			this.user.dob = dobInput.Value;
			this.user.password = passwordInput.Text;
			this.user.full_address = addressInput.Text;
			this.user.type = 3;
			// This adds the address
			checkCityAndCountry();
			db.User.Add(this.user);
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

		private void loginBtn_Click(object sender, EventArgs e) {
			var userInfo= db.User.Where(i => i.email == emailInput1.Text && i.password == passwordInput1.Text).Select(i => new {
				id = i.id,
				type = i.UserType.type
			}).ToList();

			if (userInfo.Count == 1) {
				var HomePage = new HomePageForm(userInfo[0].id, userInfo[0].type);
				HomePage.Show();
				this.Hide();
			}
		}
	}
}
