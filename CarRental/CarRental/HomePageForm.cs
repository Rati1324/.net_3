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
	public partial class HomePageForm : Form {
		public HomePageForm() {
			InitializeComponent();
		}

		private void impotBtn_Click(object sender, EventArgs e) {
			CarRentalEntities db = new CarRentalEntities();
			var data = db.Staffs.Select(i => new {
				FirstName = i.User.f_name,
				LastName = i.User.l_name,
				City = i.User.Address1.City1.name,
				Role = i.Role1.name,
				Branch = i.Branch1.Address1.City1.name
			});
			mainGrid.DataSource = data.ToList();
		}
	}
}
