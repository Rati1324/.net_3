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
				DataTable dtGender = GetData("SELECT ID, NameGe as 'NAME' FROM Gender");
				genderInput.DataSource = dtGender;
				genderInput.DisplayMember = "NAME";
				genderInput.ValueMember = "ID";

				DataTable dtRoles = GetData("SELECT ID, NameGe AS 'NAME' FROM Roles");
				roleInput.DataSource = dtRoles;
				roleInput.DisplayMember = "NAME";
				roleInput.ValueMember = "ID";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		DataTable GetData(string query)
		{
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["edu"].ConnectionString))
			{
				using (SqlCommand com = new SqlCommand(query, conn))
				{
					conn.Open();
					SqlDataReader sdr = com.ExecuteReader();
					DataTable dt = new DataTable();
					dt.Load(sdr);
					return dt;
				}		
			}
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			try
			{
				User user = new User();
				user.FirstName = f_nameInput.Text;
				user.LastName = l_nameInput.Text;
				user.PersonalNumber = idInput.Text;
				user.PhoneNumber = phoneInput.Text;
				user.BirthDate = dobInput.Value.Date;
				user.GenderID = (int)genderInput.SelectedValue;
				user.EMail = emailInput.Text;
				user.RoleID = (int)roleInput.SelectedValue;

				string query = $"INSERT INTO Users VALUES(" +
					$"'{user.FirstName}','{user.LastName}','{user.PersonalNumber}'," +
					$"'{user.BirthDate.Value.ToString("dd.MM.yyyy")}',{user.GenderID},'{user.PhoneNumber}','{user.EMail}',{user.RoleID})";
				MessageBox.Show(query);
				using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["edu"].ConnectionString))
				{
					using (SqlCommand com = new SqlCommand(query, conn))
					{
						conn.Open();
						try
						{
							com.ExecuteNonQuery();
						}
						catch (Exception ex)
						{
							throw new Exception($"error {ex}");
						}
					}
				}
			}

			catch (Exception)
			{

				throw;
			}
		}
	}
}
