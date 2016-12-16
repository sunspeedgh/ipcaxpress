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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
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
            Administration.Accountgroup frm;
            frm = new Administration.Accountgroup(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
            //if (this.ActiveMdiChild != null)
            //    this.ActiveMdiChild.Close();
            //Administration.Accountgroup frmaccgrp = new Administration.Accountgroup();
            //frmaccgrp.MdiParent = this;
            //frmaccgrp.Show();
            //sptCtrlMastermenu.Panel2.Controls.Add(frmaccgrp);
        }

        private void barbtnAuthotmain_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.Author frm;
            frm = new Administration.Author(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void barbtnBillmaterial_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.BillsofMaterial frm;
            frm = new Administration.BillsofMaterial(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.Costcenter frm;
            frm = new Administration.Costcenter(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void barbtnCostgroup_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.Costcentergroup frm;
            frm = new Administration.Costcentergroup(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void barbtnCurrency_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.Currencyadd frm;
            frm = new Administration.Currencyadd(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void barbtnCurrencyconv_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.Currencyconversion frm;
            frm = new Administration.Currencyconversion(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void barbtnSalesman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.Salesman frm;
            frm = new Administration.Salesman(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void barbtnStdNarration_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.StdNarration frm;
            frm = new Administration.StdNarration(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
        }

        private void barbtnMastNarration_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Administration.Masterseriesgroup frm;
            frm = new Administration.Masterseriesgroup(); //generate new instance 
            frm.Owner = this;
            frm.TopLevel = false;

            sptCtrlMastermenu.Panel2.Controls.Add(frm);
            frm.Show();
        }
    }
}