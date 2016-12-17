using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCAUI.Administration
{
    public partial class Costcenter : Form
    {
        public Costcenter()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void navBarList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            // Administration.Accountgroup frm;
            //frm = new Administration.Accountgroup(); //generate new instance 
            //frm.Owner = this;
            //frm.TopLevel = false;

            //sptCtrlMastermenu.Panel2.Controls.Add(frm);
            //frm.Show();
        }
    }
}
