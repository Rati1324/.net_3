using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw10 {
	public partial class reportsForm<T> : Form {
		public reportsForm(Report<T> report) {
			InitializeComponent();
			this.Text = report.Name;
			this.reportGrid.DataSource = report.Data;
		}
	}
}
