﻿using System;
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

		private void getBooks_Click(object sender, EventArgs e)
		{
			Book B = new Book();
			B.GetInfo();
			DataTable bookData = B.GetInfo();
			dataGrid.DataSource = bookData;
		}

		private void addBookBtn_Click(object sender, EventArgs e)
		{
			addBookForm bookForm = new addBookForm();
			bookForm.Show();
		}
	}
}
