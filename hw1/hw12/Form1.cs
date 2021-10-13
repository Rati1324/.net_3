﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hw12
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void importBtn_Click(object sender, EventArgs e)
		{
			try
			{
				DB db = new DB();
				DataTable dt = db.GetData("SELECT * FROM Users");
				studentGrid.DataSource = dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			UserForm user = new UserForm();
			user.Show();
		}

		private void studentGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var data = (DataGridView)sender;
			var values = data.Rows[e.RowIndex];

			int id = Int32.Parse(values.Cells["ID"].Value.ToString());
			string PersonalId = values.Cells["PersonalNumber"].Value.ToString();
			string FistName = values.Cells["FirstName"].Value.ToString();
			string LastName = values.Cells["LastName"].Value.ToString();
			string personalNumber = values.Cells["PersonalNumber"].Value.ToString();
			DateTime? birthDate = (DateTime?)values.Cells["BirthDate"].Value;
			int genderId = Int32.Parse(values.Cells["GenderID"].Value.ToString());
			string phoneNumber = values.Cells["PhoneNumber"].Value.ToString();
			string email = values.Cells["EMail"].Value.ToString();
			int roleId = Int32.Parse(values.Cells["RoleId"].Value.ToString());

			User u = new User(id, FistName, LastName, personalNumber, birthDate, genderId, phoneNumber, email, roleId);

			if (e.ColumnIndex == 0)
			{
				u.Update();
			}
			else if (e.ColumnIndex == 1)
			{
				u.Delete();
				data.Rows.RemoveAt(e.RowIndex);
			}
		}
	}
}
