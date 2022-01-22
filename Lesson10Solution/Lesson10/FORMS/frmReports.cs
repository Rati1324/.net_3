using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson10
{
    public partial class frmReports<T> : Form
    {       
        public frmReports(Report<T> report)
        {
            InitializeComponent();
            this.Text = report.Name;
            this.dataGridView_report.DataSource = report.Data;
          
        }
    }
}
