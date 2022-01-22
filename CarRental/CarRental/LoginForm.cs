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
	public partial class LoginForm : Form {
		CarRentalEntities db = new CarRentalEntities();
		public LoginForm() {
			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e) {
			string inputEmail = emailInput.Text;
			string inputPassword = passwordInput.Text;

			var user = db.Users.Where(i => i.email == inputEmail && i.password == inputPassword).Select(i => new {
				email = i.email,
				password = i.password,
			}).ToList();

			if (user.Count == 1) {
				var HomePage = new HomePageForm();
				HomePage.Show();
			}
		}
	}
}
