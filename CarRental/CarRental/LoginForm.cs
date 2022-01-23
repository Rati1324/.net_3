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

			var userInfo= db.User.Where(i => i.email == inputEmail && i.password == inputPassword).Select(i => new {
				id = i.id,
				email = i.email,
				password = i.password,
				type = i.UserType.type
			}).ToList();

			//MessageBox.Show(userInfo.GetType().ToString());
			if (userInfo.Count == 1) {
				var HomePage = new HomePageForm(userInfo[0].id, userInfo[0].type);
				HomePage.Show();
				this.Hide();
			}
		}
	}
}
