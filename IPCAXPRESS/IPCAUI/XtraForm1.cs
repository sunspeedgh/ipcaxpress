﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;

namespace IPCAUI
{
    public partial class XtraForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            //windowsUIView1_QueryControl  += windowsUIView1_QueryControl();
            // This line of code is generated by Data Source Configuration Wizard

            treeList1.OptionsBehavior.Editable = false;
            treeList1.OptionsView.ShowColumns = false;
            treeList1.OptionsView.ShowIndicator = false;
            treeList1.OptionsView.ShowHorzLines = false;
            treeList1.OptionsView.ShowVertLines = false;
        }

        private void windowsUIView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            //if (e.Document == document1)
            //    e.Control = new Transactions.SalesVoucher();
            //if (e.Document == document2)
            //    e.Control = new Reports.Accountbooks.AccountLedger();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                MessageBox.Show("Are You Want To Exit IPCAExpress");
                
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void treeList1_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            DevExpress.XtraTreeList.TreeList tl = sender as DevExpress.XtraTreeList.TreeList;
            if (e.Node == tl.FocusedNode)
            {
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                Rectangle R = new Rectangle(e.EditViewInfo.ContentRect.Left, e.EditViewInfo.ContentRect.Top, Convert.ToInt32(e.Graphics.MeasureString(e.CellText, e.Appearance.Font).Width - 2), e.Appearance.FontHeight);
                e.Graphics.FillRectangle(SystemBrushes.Highlight, R);
                e.Graphics.DrawString(e.CellText, e.Appearance.Font, SystemBrushes.HighlightText, R, e.Appearance.GetStringFormat());
                e.Handled = true;
            }
        }
        private void dockPanel2_Click(object sender, EventArgs e)
        {

        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            
        }

        private void treeList1_Click(object sender, EventArgs e)
        {
            //DevExpress.XtraTreeList.TreeList tree = sender as DevExpress.XtraTreeList.TreeList;
            //DevExpress.XtraTreeList.TreeListHitInfo info = tree.CalcHitInfo(tree.PointToClient(MousePosition));
            //if (info.HitInfoType == DevExpress.XtraTreeList.HitInfoType.Cell) ;
            //Reports.Accountbooks.AccountGroupLedger frm = new Reports.Accountbooks.AccountGroupLedger();
            //frm.Show();
        
        }

        private void treeList1_NodeChanged(object sender, DevExpress.XtraTreeList.NodeChangedEventArgs e)
        {

        }

        private void treeList1_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            //treeList1.FocusedNode = treeList1.Nodes[0];
            tileControl1.Visible = false;
            //e.Node.Selected = 1;
            Reports.BS_Horizontal frm = new Reports.BS_Horizontal();
            frm.MdiParent = this;
            frm.Show();
        }

        private void treeList1_AfterCollapse(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {

        }

        private void treeList1_GetNodeDisplayValue(object sender, DevExpress.XtraTreeList.GetNodeDisplayValueEventArgs e)
        {

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_SelectedPageChanged(object sender, EventArgs e)
        {
            string selectedPage = (sender as RibbonControl).SelectedPage.Name.ToString();

            switch (selectedPage)
            {
                case "Reports":
                    this.Hide();                     
                    IPCAUI.Menu.ReportMenu frmReport = new IPCAUI.Menu.ReportMenu(this);                                    
                    frmReport.Show();                   
                    break;
                case "Transactions":
                    this.Hide();
                    IPCAUI.Menu.TransactionsMenu frmTransMenu = new IPCAUI.Menu.TransactionsMenu(this);
                    frmTransMenu.Show();
                    break;
                case "Master":
                    this.Hide();
                    IPCAUI.Menu.MastersMenu frmMasterMenu = new IPCAUI.Menu.MastersMenu(this);
                    frmMasterMenu.Show();
                    break;
                case "Configuration":
                    this.Hide();
                    IPCAUI.Menu.ConfigurationMenu frmConfigMenu = new IPCAUI.Menu.ConfigurationMenu(this);
                    frmConfigMenu.Show();
                    break;
                case "Merged Accounts":
                    break;
                case "Single Column":
                    break;
                case "Multiple Column":
                    break;
                case "Bank Book(As per Clr.Date)":
                    break;
                default:
                    break;
            }

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

        }
    }
}