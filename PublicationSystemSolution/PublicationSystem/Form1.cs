using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublicationSystem
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dataGrid.Columns.Add("Name", "Name");
			dataGrid.Columns.Add("Authors", "Authors");
			dataGrid.Columns.Add("Publisher", "Publisher");
			dataGrid.Columns.Add("Date", "Date");

			Book B = new Book();
			B.test2();
			//DataTable bookData = B.GetInfo();

		}
	}
}
