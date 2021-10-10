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
		public Form1()
		{
			InitializeComponent();
		}

		private void importBtn_Click(object sender, EventArgs e)
		{
			try
			{
				string query = "SELECT * FROM Users";
				string connString = ConfigurationManager.ConnectionStrings["edu"].ConnectionString;
				SqlConnection conn = new SqlConnection(connString);
				SqlCommand com = new SqlCommand(query, conn);
				SqlDataReader sdr = null;

				DataTable dt = new DataTable();
				try
				{
					conn.Open();
					sdr = com.ExecuteReader();
					SqlDataAdapter ad = new SqlDataAdapter(com);
					dt.Load(sdr);
				}
				catch (Exception)
				{
					throw;
				}
				finally
				{
					conn.Close();
					conn.Dispose();
					studentGrid.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void addBtn_Click(object sender, EventArgs e)
		{
			User user = new User();
			user.Show();
		}
	}
}
