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
    public partial class Purchasetype : DevExpress.XtraEditors.XtraForm
    {
        public Purchasetype()
        {
            InitializeComponent();
        }

        private void ListPurchase_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Administration.List.PurchaseList frmList = new Administration.List.PurchaseList();
            frmList.StartPosition = FormStartPosition.CenterScreen;

            frmList.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if (tbxPurchaseType.Text.Equals(string.Empty))
            //{
            //    MessageBox.Show("Purchase Type can not be blank!");
            //    return;
            //}

            ////if (objpurBL.IsPurchaseExists(tbxSalesType.Text.Trim()))
            ////{
            ////    MessageBox.Show("Sales Type Name already Exists!", "SunSpeed", MessageBoxButtons.RetryCancel);
            ////    tbxSalesType.Focus();
            ////    return;
            ////}
            //PurchaseTypeModel obj = new PurchaseTypeModel();

            //obj.PurchaseType = tbxPurchaseType.Text.Trim();
            ////this GroupBox for Purchase Account Information of RadioButton
            //obj.typeSpecifyHereSingleAccount = rbnSingleaccount.Checked ? true : false;
            //obj.typeTaxable = rbnSingleaccount.Checked ? true : false;
            //obj.LedgerAccountBox = cbxEnableDefComm.SelectedItem.ToString();
            //obj.typeSpecifyINVoucher = rbnVoucher.Checked ? true : false;

            ////TaxationType: RadioButton Group
            //obj.typeTaxable = rbnTaxable.Checked ? true : false;
            //obj.typeMultiTax = rbnMultitax.Checked ? true : false;
            //obj.typeAgainstSTFrom = rbnAganistst.Checked ? true : false;
            //obj.typeTaxpaid = rbnTaxpaid.Checked ? true : false;
            //obj.typeExempt = rbnExempt.Checked ? true : false;
            //obj.typeTaxFree = rbnTaxfree.Checked ? true : false;
            //obj.typeLUMSumDealer = rbnLumpsumDealer.Checked ? true : false;
            //obj.typeUnRegDealer = rbnUnregDealer.Checked ? true : false;

            //// other Information Group
            //obj.InputTaxCedit = cbxInputCredit.SelectedItem.ToString();
            //obj.CapitalPurchase = cbxCapitalPurchase.SelectedItem.ToString();
            //obj.TaxReport = cbxTaxReport.SelectedItem.ToString();

            ////if Enable MultiTax Will Show on other Information Group

            ////Region Radio Button GroupBox
            //obj.TypeLocal = rbnLocal.Checked ? true : false;
            //obj.TypeCentral = rbnCenter.Checked ? true : false;

            ////Type of Transaction on Region GrupBox Sub
            //obj.TypeStockTransfer = rbnStockTrans.Checked ? true : false;
            //obj.TypeOther = rbnOther.Checked ? true : false;
            //obj.ImportNormal = rbnImportNormal.Checked ? true : false;
            //obj.ImportHighsea = rbnImportHigh.Checked ? true : false;
            //obj.PurchaseinTransit = rbnPurchSale.Checked ? true : false;
            //                     .
            // //Form Information:if Enabl typeAgainstSTFrom
            //obj.IssueSTFrom = cbxIssueSt.SelectedItem.ToString();
            //obj.FromIssuable = cbxIssuableYN.SelectedItem.ToString();
            //obj.ReceiveSTForm = cbxReceiableST.SelectedItem.ToString();
            //obj.FromReceivable = cbxReceivable.SelectedItem.ToString();

            ////Tax Calculation
            //obj.SingleTaxRate = rbnSingleTaxRate.Checked ? true : false;
            //obj.MultiTaxRate = rbnMultiTaxRate.Checked ? true : false;
            //obj.TaxInPercentage =Convert.ToInt32(tbxTaxinPersentage.Text.Trim());
            //obj.TaxInSurcharge = Convert.ToInt32(tbxSurchargeinPer.Text.Trim());
            //obj.FreezTaxInPurchase = cbxFreezeTaxpurchase.SelectedItem.ToString();
            //obj.FreezTaxInPurchaseReturn = cbxFreezeTaxpurchaseReturn.SelectedItem.ToString();
            //obj.InvoiceHeading = tbxInvoiceHeading.Text.Trim();
            //obj.InvoicDescription = tbxInvoiceDescription.Text.Trim();

            //obj.CreatedBy = "Admin";
            ////PurchaseTypeBL purchasebl = new PurchaseTypeBL();
            //bool isSuccess = objpurBL.SavePurchaseType(obj);
            //////Dialogs.PopUPDialog d = new Dialogs.PopUPDialog("Saved Successfully!");
            //////d.ShowDialog();

            ////List<SaleTypeModel> lstSales = salObj.GetAllSaleType();
            ////dgvList.DataSource = lstSales;

            //Dialogs.PopUPDialog d = new Dialogs.PopUPDialog("Saved Successfully!");
            //d.ShowDialog();
        }
    }
}
