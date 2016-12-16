using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace IPCAUI.Menu
{
    public partial class MastersMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraForm1 frm;
        public MastersMenu(XtraForm1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void MastersMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Visible = true;
        }

        private void barbtnAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.Account frm;
            frm = new Administration.Account(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;
            
            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();

            //if (this.ActiveMdiChild != null)
            //    this.ActiveMdiChild.Close();
            //Administration.Account frmacc = new Administration.Account();
            //frmacc.MdiParent = this;
            //frmacc.Show();
            //sptCtrlMastermenu.Panel2.Controls.Add(frmacc);
        }

        private void barbtnAccGroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            Administration.Accountgroup frmaccgrp = new Administration.Accountgroup();
            frmaccgrp.MdiParent = this;
            frmaccgrp.Show();
            sptCtrlMastermenu.Panel2.Controls.Add(frmaccgrp);
        }
    }
}