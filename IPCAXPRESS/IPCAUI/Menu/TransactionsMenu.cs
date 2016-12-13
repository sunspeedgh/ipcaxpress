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
using DevExpress.XtraBars.Ribbon;

namespace IPCAUI.Menu
{
    public partial class TransactionsMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        XtraForm1 frm;
        public TransactionsMenu(XtraForm1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void TransactionsMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Visible = true;
        }

        private void rbCtrlTransactions_Click(object sender, EventArgs e)
        {

        }

        private void rbCtrlTransactions_SelectedPageChanged(object sender, EventArgs e)
        {
            string selectedPage = (sender as RibbonControl).SelectedPage.Name.ToString();

            //switch (selectedPage)
            //{
            //    case "Reports":
            //        this.Hide();
            //        IPCAUI.Menu.ReportMenu frmReport = new IPCAUI.Menu.ReportMenu(this);
            //        frmReport.Show();
            //        break;
            //    case "Transactions":
            //        this.Hide();
            //        IPCAUI.Menu.TransactionsMenu frmTransMenu = new IPCAUI.Menu.TransactionsMenu(this);
            //        frmTransMenu.Show();
            //        break;
            //    case "Master":
            //        this.Hide();
            //        IPCAUI.Menu.MastersMenu frmMasterMenu = new IPCAUI.Menu.MastersMenu(this);
            //        frmMasterMenu.Show();
            //        break;
            //    case "Configuration":
            //        this.Hide();
            //        IPCAUI.Menu.ConfigurationMenu frmConfigMenu = new IPCAUI.Menu.ConfigurationMenu(this);
            //        frmConfigMenu.Show();
            //        break;
            //    case "Merged Accounts":
            //        break;
            //    case "Single Column":
            //        break;
            //    case "Multiple Column":
            //        break;
            //    case "Bank Book(As per Clr.Date)":
            //        break;
            //    default:
            //        break;
            //}

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Payment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            IPCAUI.Transactions.PaymentVoucher frmPayment = new Transactions.PaymentVoucher();
            frmPayment.MdiParent = this;
            frmPayment.Show();
            splitContainerControl1.Panel2.Controls.Add(frmPayment);
        }

        private void SalesEntry_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();
                

            IPCAUI.Transactions.SalesVoucher frmSales = new Transactions.SalesVoucher();
            frmSales.MdiParent = this;
            frmSales.Show();
            splitContainerControl1.Panel2.Controls.Add(frmSales);
        }
    }
}