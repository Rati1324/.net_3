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
	public partial class RegisterForm : Form {
		private CarRentalEntities db = new CarRentalEntities();
		public RegisterForm() {
			InitializeComponent();
		}

		private void registerBtn_Click(object sender, EventArgs e) {
			User u = new User();
			u.f_name = fNameInput.Text;
			u.l_name = lNameInput.Text;
			u.phone = phoneInput.Text;
			u.personal_id = pIdInput.Text;
			u.email = emailInput.Text;
			u.dob = dobInput.Value;
			u.password = passwordInput.Text;
			// This adds the address
			db.SaveChanges();
		}
	}
}
