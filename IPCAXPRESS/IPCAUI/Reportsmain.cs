using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCAUI
{
    public partial class Reportsmain : Form
    {
        public Reportsmain()
        {
            InitializeComponent();
        }

        private void finalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add("Report1");
            listBoxControl1.Items.Add("Report2");
            listBoxControl1.Items.Add("Report3");
            listBoxControl1.Items.Add("Report4");
        }

        private void trialbalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Clear();
            listBoxControl1.Items.Add("Trial Balance1");
            listBoxControl1.Items.Add("Trial Balance2");
            listBoxControl1.Items.Add("Trial Balance3");
        }

        private void Reportsmain_Load(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.MdiParent = this;
            frm.Show();
            splitContainerControl1.Panel2.Controls.Add(frm);

            frm.Dock = DockStyle.Fill;
        }
    }
}
