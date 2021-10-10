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
	public partial class User : Form
	{
		public User()
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
			}
			catch (Exception)
			{

				throw;
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
	}
}
