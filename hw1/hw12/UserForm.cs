using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw12
{
	public partial class UserForm : Form
	{
		public UserForm()
		{
			InitializeComponent();
		}

		private void User_Load(object sender, EventArgs e)
		{
			try
			{
				DB db = new DB();
				DataTable dtGender = db.GetData("SELECT ID, NameGe as 'NAME' FROM Gender");
				genderInput.DataSource = dtGender;
				genderInput.DisplayMember = "NAME";
				genderInput.ValueMember = "ID";

				DataTable dtRoles = db.GetData("SELECT ID, NameGe AS 'NAME' FROM Roles");
				roleInput.DataSource = dtRoles;
				roleInput.DisplayMember = "NAME";
				roleInput.ValueMember = "ID";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		private void addBtn_Click(object sender, EventArgs e)
		{
			try
			{
				User user = new User(idInput.Text, f_nameInput.Text, l_nameInput.Text, phoneInput.Text,
					dobInput.Value.Date, (int)genderInput.SelectedValue, phoneInput.Text, emailInput.Text, 
					(int)roleInput.SelectedValue);
				user.insert();
			}

			catch (Exception)
			{

				throw;
			}
		}
	}
}
