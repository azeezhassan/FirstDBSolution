using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstDBWinApp
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'FirstDBDataSet.StudentInfo' table. You can move, or remove it, as needed.
            this.StudentInfoTableAdapter.Fill(this.FirstDBDataSet.StudentInfo);

            this.reportViewer1.RefreshReport();
        }
    }
}
