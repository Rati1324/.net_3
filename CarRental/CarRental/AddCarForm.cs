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
		private int id;
		private Car car = new Car();
		CarRentalEntities db = new CarRentalEntities();

		public AddCarForm(int id = 0) {
			InitializeComponent();
			var transmissions = db.TransmissionType.Select(i => new {id = i.id, name = i.name}).ToList();
			#region dropdown items
			List<Object> items = new List<Object>() {};

			transmissionInput.DisplayMember = "Text";
			transmissionInput.ValueMember = "Value";
			foreach (var t in transmissions) {
				items.Add(new { Text = t.name, Value = t.id });
			}
			transmissionInput.SelectedValue = items.First();
			transmissionInput.DataSource = items;
			items.Clear();
			
			branchInput.DisplayMember = "Text";
			branchInput.ValueMember = "Value";
			var branches = db.Branch.Select(i => new { id = i.id, name = i.City1.name }).ToList();
			foreach (var b in branches) {
				items.Add(new { Text = b.name, Value = b.id });
			}
			branchInput.SelectedValue = items.First();
			branchInput.DataSource = items;
			items.Clear();

			fuelInput.DisplayMember = "Text";
			fuelInput.ValueMember = "Value";
			var fuels = db.FuelType.Select(i => new { id = i.id, name = i.name }).ToList();
			foreach (var f in fuels) {
				items.Add(new { Text = f.name, Value = f.id });
			}
			fuelInput.SelectedValue = items.First();
			fuelInput.DataSource = items;
			items.Clear();

			bodyTypeInput.DisplayMember = "Text";
			bodyTypeInput.ValueMember = "Value";
			var bodyTypes = db.CarBodyType.Select(i => new { id = i.id, name = i.name }).ToList();
			foreach (var b in bodyTypes) {
				items.Add(new { Text = b.name, Value = b.id });
			}
			bodyTypeInput.SelectedValue = items.First();
			bodyTypeInput.DataSource = items;

			if (id == 0) {
				saveCarBtn.Hide();
			} 
			else {
				this.id = id;
				populate();
			}
			#endregion
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
			db.Car.Add(this.car);
			db.SaveChanges();
		}

		private void populate() {
			this.car = db.Car.Where(i => i.id == this.id).Select(u => u).First();

			#region dropdowns
			int transmissionIndex = 0;
			for (int i = 0; i < transmissionInput.Items.Count; i++) {
				if (transmissionInput.Items[i].Equals(this.car.TransmissionType.name)) {
					transmissionIndex = i;
				}
			}
			transmissionInput.SelectedIndex = transmissionIndex;

			int fuelTypeIndex = 0;
			for (int i = 0; i < fuelInput.Items.Count; i++) {
				if (fuelInput.Items[i].Equals(this.car.FuelType.name)) {
					fuelTypeIndex = i;
				}
			}
			fuelInput.SelectedIndex = fuelTypeIndex;

			int bodyTypeIndex = 0;
			for (int i = 0; i < bodyTypeInput.Items.Count; i++) {
				if (bodyTypeInput.Items[i].Equals(this.car.CarBodyType.name)) {
					bodyTypeIndex = i;
				}
			}
			bodyTypeInput.SelectedIndex = bodyTypeIndex;

			int branchIndex = 0;
			for (int i = 0; i < branchInput.Items.Count; i++) {
				if (branchInput.Items[i].Equals(this.car.CarBodyType.name)) {
					bodyTypeIndex = i;
				}
			}
			#endregion

			//bodyTypeInput.SelectedIndex = ;
			//branchInput.SelectedIndex = ;
			fuelInput.Text = this.car.fuel_type.ToString();
			yearInput.Text = this.car.year.ToString();
			powerInput.Text = this.car.power_hp.ToString();
			speedInput.Text = this.car.speed.ToString();
			priceInput.Text = this.car.branch.ToString();
			priceInput.Text = this.car.price.ToString();
			licenseInput.Text = this.car.license_number;
		}
	}
}
