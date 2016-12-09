using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCAUI.Reports
{
    public partial class BS_Grid : Form
    {
        public BS_Grid()
        {
            InitializeComponent();
        }

        private void BS_Grid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iPCADataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.iPCADataSet1.Customer);
            // TODO: This line of code loads data into the 'iPCADataSet.Approvers' table. You can move, or remove it, as needed.
            this.approversTableAdapter.Fill(this.iPCADataSet.Approvers);

        }

        private void gridSplitContainer1Grid_Click(object sender, EventArgs e)
        {

        }
    }
}
