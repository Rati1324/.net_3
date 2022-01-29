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
		private CarRentalEntities db = new CarRentalEntities();
		public HomePageForm(int id, string UserType) {
			if (UserType != "Admin") {
				addUserBtn.Hide();
			}
			InitializeComponent();
		}

		private void importBtn_Click(object sender, EventArgs e) {
			string selected = importSelect.Text;
			if (selected == "Cars") {
				var data = db.Car.Select(i => new {
					Id = i.id,
					Name = i.name,
					Year = i.year,
					Power = i.power_hp,
					Transmission = i.TransmissionType.name,
					FuelType = i.FuelType.name,
					BodyType = i.CarBodyType.name,
					Speed = i.speed,
					Branch = i.Branch1.City1.name,
					Price = i.price,
					LicenseNumber = i.license_number
				}); ;
				mainGrid.DataSource = data.ToList();
				mainGrid.Columns[0].Visible = false;
			}
			else {
				var data = db.User.Where(u => u.UserType.type == "Moderator").Select(i => new {
					Id = i.id,
					FirstName = i.f_name,
					LastName = i.l_name,
					PersonalId = i.personal_id,
					Email = i.email,
					Phone = i.phone,
					Password = i.password,
					Dob = i.dob,
					//Country = i.Address1.Country1.name,
					//City = i.Address1.City1.name,
					Street = i.full_address
				}).ToList();

				// Need to compine additionaldata
				mainGrid.DataSource = data;
				mainGrid.Columns[0].Visible = false;
			}
		}

		private void addUserBtn_Click(object sender, EventArgs e) {
			AddUserForm userForm = new AddUserForm();
			userForm.Show();
		}

		private void editItemBtn_Click(object sender, EventArgs e) {
			if (importSelect.Text.Equals("Cars")) {
				int index = mainGrid.SelectedCells[0].RowIndex;
				int id = Int32.Parse(mainGrid.Rows[index].Cells[0].Value.ToString());
				AddCarForm carForm = new AddCarForm(mainGrid.Rows[index]);
				carForm.Show();
			}
			else {
				int index = mainGrid.SelectedCells[0].RowIndex;
				int id = Int32.Parse(mainGrid.Rows[index].Cells[0].Value.ToString());
				AddUserForm userForm = new AddUserForm(id);
				userForm.Show();
			}
		}

		private void addCarBtn_Click(object sender, EventArgs e) {
			AddCarForm carForm = new AddCarForm();
			carForm.Show();
		}

		private void deleteBtn_Click(object sender, EventArgs e) {
			if (importSelect.Text == "Cars") {
				int index = mainGrid.SelectedCells[0].RowIndex;
				int id = Int32.Parse(mainGrid.Rows[index].Cells[0].Value.ToString());
				Car c = db.Car.Where(i => i.id == id).First();
				db.Car.Remove(c);
			}
			else {
				int index = mainGrid.SelectedCells[0].RowIndex;
				int id = Int32.Parse(mainGrid.Rows[index].Cells[0].Value.ToString());
				User c = db.User.Where(i => i.id == id).First();
				db.User.Remove(c);
			}
			db.SaveChanges();
			importBtn.PerformClick();
		}
	}
}
