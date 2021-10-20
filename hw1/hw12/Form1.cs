using System;
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
		private User currentUser = null;
		public Form1()
		{
			InitializeComponent();
		}

		private void importBtn_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable dt = DB.GetData("SELECT * FROM Users");
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

	
		private void saveBtn_Click(object sender, EventArgs e)
		{
			try
			{
				if (currentUser != null)
				{
					string date = currentUser.BirthDate.Value.ToString("yyyy-MM-dd");
					string query = $"UPDATE Users SET FirstName='{currentUser.FirstName}', LastName='{currentUser.LastName}', PersonalNumber='{currentUser.PersonalNumber}', " +
						$"BirthDate='{date}', GenderID={currentUser.GenderID}, PhoneNumber='{currentUser.PhoneNumber}', EMail='{currentUser.EMail}', RoleID='{currentUser.RoleID}' WHERE id={currentUser.Id}";
					DB.Execute(query);
				}
			}
			catch (Exception x)
			{
				MessageBox.Show($"Error has occured: {x.Message}");
				throw;
			}
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (currentUser != null)
			{
				if(MessageBox.Show("დარწმუნებული ხართ, რომ გსურთ წაშლა?", "შეკითხვა", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
				{
					try
					{
						string query = "DELETE from Users WHERE id = @UserId";
						using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["edu"].ConnectionString))
						{
							using (SqlCommand com = new SqlCommand(query, conn))
							{
								com.Parameters.AddWithValue("@UserId", currentUser.Id);
								try
								{
									conn.Open();
									com.ExecuteNonQuery();
								}
								catch (Exception ex)
								{
									throw new Exception($"error {ex}");
								}
							}
						}

						studentGrid.Rows.Remove(studentGrid.SelectedRows[0]);
					}
					catch (Exception x)
					{
						MessageBox.Show($"Error has occured: {x.Message}");
					}
				
				}
			}
		}

		private void studentGrid_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (studentGrid.SelectedRows.Count == 1 && e.RowIndex != studentGrid.Rows.Count - 1)
				{
					var row = studentGrid.SelectedRows[0];
					currentUser = new User();
					
					currentUser.Id = Int32.Parse(row.Cells["ID"].Value.ToString());
					currentUser.PersonalNumber = row.Cells["PersonalNumber"].Value.ToString();
					currentUser.FirstName = row.Cells["FirstName"].Value.ToString();
					currentUser.LastName = row.Cells["LastName"].Value.ToString();
					currentUser.PersonalNumber = row.Cells["PersonalNumber"].Value.ToString();
					currentUser.BirthDate = (DateTime?)row.Cells["BirthDate"].Value;
					currentUser.GenderID = Int32.Parse(row.Cells["GenderID"].Value.ToString());
					currentUser.PhoneNumber = row.Cells["PhoneNumber"].Value.ToString();
					currentUser.EMail = row.Cells["EMail"].Value.ToString();
					currentUser.RoleID = Int32.Parse(row.Cells["RoleId"].Value.ToString());
				}
			}
			catch (Exception x)
			{
				MessageBox.Show($"Error: {x.Message}");
			}
		}
	}
}
