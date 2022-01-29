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
	public partial class AddCarForm : Form {
		private Car car = new Car();
		private int id;

		CarRentalEntities db = new CarRentalEntities();

		public AddCarForm(DataGridViewRow d = null) {
			InitializeComponent();
			if (d == null) {
				fillComboboxes();
				saveCarBtn.Hide();
			} 
			else {
				fillComboboxes(d.Cells[4].Value.ToString(), d.Cells[5].Value.ToString(), d.Cells[6].Value.ToString(), d.Cells[8].Value.ToString());
				this.id = Int32.Parse(d.Cells[0].Value.ToString());

				fillInputs(d.Cells[1].Value.ToString(), d.Cells[2].Value.ToString(), d.Cells[3].Value.ToString(), d.Cells[7].Value.ToString(), d.Cells[9].Value.ToString(), d.Cells[10].Value.ToString());
			}
		}

		private void addBtn_Click(object sender, EventArgs e) {
			this.car.name = nameInput.Text;
			this.car.speed = Int32.Parse(speedInput.Text);
			this.car.price = Int32.Parse(priceInput.Text);
			this.car.power_hp = Int32.Parse(powerInput.Text);
			this.car.name = nameInput.Text;
			this.car.license_number = licenseInput.Text;
			this.car.transmission_type = Int32.Parse(transmissionInput.SelectedValue.ToString());
			this.car.branch = Int32.Parse(branchInput.SelectedValue.ToString());
			this.car.body_type = Int32.Parse(bodyTypeInput.SelectedValue.ToString());
			this.car.fuel_type = Int32.Parse(fuelInput.SelectedValue.ToString());
			this.car.year = Int32.Parse(yearInput.Text.ToString());
			db.Car.Add(this.car);
			db.SaveChanges();
		}

		private void saveCarBtn_Click(object sender, EventArgs e) {
			this.car = db.Car.Where(c => c.id == this.id).First();

			this.car.name = nameInput.Text;
			this.car.speed = Int32.Parse(speedInput.Text);
			this.car.price = decimal.Parse(priceInput.Text);
			this.car.power_hp = Int32.Parse(powerInput.Text);
			this.car.name = nameInput.Text;
			this.car.license_number = licenseInput.Text;
			this.car.transmission_type = Int32.Parse(transmissionInput.SelectedValue.ToString());
			this.car.branch = Int32.Parse(branchInput.SelectedValue.ToString());
			this.car.body_type = Int32.Parse(bodyTypeInput.SelectedValue.ToString());
			this.car.fuel_type = Int32.Parse(fuelInput.SelectedValue.ToString());
			this.car.year = Int32.Parse(yearInput.Text);

			db.SaveChanges();
		}

		private void fillComboboxes(string Transmission="", string FuelType="", string BodyType="", string Branch="") {
			int index = 0;

			var transmissions = db.TransmissionType.Select(i => new {id = i.id, name = i.name}).ToList();
			transmissionInput.DisplayMember = "name";
			transmissionInput.ValueMember = "id";
			transmissionInput.DataSource = transmissions;
			if (!string.IsNullOrEmpty(Transmission)) {
				index = transmissions.FindIndex(i => i.name == Transmission);
			}
			else {
				index = 0;
			}
			transmissionInput.SelectedIndex = index;

			var branches = db.Branch.Select(i => new { id = i.id, name = i.City1.name }).ToList();
			branchInput.DisplayMember = "name";
			branchInput.ValueMember = "id";
			branchInput.DataSource = branches;
			if (!string.IsNullOrEmpty(Branch)) {
				index = branches.FindIndex(i => i.name == Branch);
			}
			else {
				index = 0;
			}
			branchInput.SelectedIndex = index;

			var fuels = db.FuelType.Select(i => new { id = i.id, name = i.name }).ToList();
			fuelInput.DisplayMember = "name";
			fuelInput.ValueMember = "id";
			fuelInput.DataSource = fuels;
			if (!string.IsNullOrEmpty(FuelType)) {
				index = fuels.FindIndex(i => i.name == FuelType);
			}
			else {
				index = 0;
			}
			fuelInput.SelectedIndex = index;

			var bodyTypes = db.CarBodyType.Select(i => new { id = i.id, name = i.name }).ToList();
			bodyTypeInput.DisplayMember = "name";
			bodyTypeInput.ValueMember = "id";
			bodyTypeInput.DataSource = bodyTypes;
			if (!string.IsNullOrEmpty(BodyType)) {
				index = bodyTypes.FindIndex(i => i.name == BodyType);
			}
			else {
				index = 0;
			}
			bodyTypeInput.SelectedIndex = index;
		}

		private void fillInputs(string name, string year, string power, string speed, string price, string licenseNumber) {
			nameInput.Text = name;
			yearInput.Text = year;
			powerInput.Text = power;
			speedInput.Text = speed;
			priceInput.Text = price;
			licenseInput.Text = licenseNumber;
		}
	}
}
