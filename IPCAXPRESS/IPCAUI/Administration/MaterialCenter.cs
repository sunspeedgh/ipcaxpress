using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eSunSpeed.BusinessLogic;
using eSunSpeedDomain;

namespace IPCAUI.Administration
{
    public partial class MaterialCenter : Form
    {
        MaterialCentreMasterBL objbal = new MaterialCentreMasterBL();
        public MaterialCenter()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MaterialCentreMasterModel objMaster = new MaterialCentreMasterModel();

            objMaster.Name = tbxGroupName.Text.Trim();
            objMaster.Alias = tbxAliasname.Text.Trim();
            objMaster.PrintName = tbxPrintname.Text.Trim();
            objMaster.Group = cbxGroupname.SelectedItem.ToString();
            objMaster.StockAccount = cbxStockaccount.SelectedItem.ToString();
            objMaster.PurchaseAccount = cbxPurchaseAccount.SelectedItem.ToString();
            objMaster.SalesAccount = cbxSaleAccount.SelectedItem.ToString();
            //objMaster.EnableStockinBal = cbxSalesAccount.SelectedItem.ToString() == "Y" ? true : false;
            //objMaster.EnableAccinTransfer = cbxStockTrans.SelectedItem.ToString() == "Y" ? true : false;
            objMaster.Address = tbxAddress.Text.Trim();
            //objMaster.Street = tbxStreet.Text.Trim();

            //CityModel objCity = (CityModel)cbxCity.SelectedItem;
            //objMaster.City = objCity.City_Name.ToString();

            //StateModel objState = (StateModel)cbxState.SelectedItem;
            //objMaster.State = objState.State_Name;

            //objMaster.Country = cbxCountry.SelectedItem.ToString();
            //objMaster.PinCode = tbxPincode.Text.Trim();
            //objMaster.Mobile = tbxMobile.Text.Trim();
            objMaster.CreatedBy = "Admin";

            bool isSuccess = objbal.SaveMaterialMaster(objMaster);
            if(isSuccess)
            {
                MessageBox.Show("Saved Successfully!");
            }

        //    List<MaterialCentreMasterModel> lstMC = accObj.GetAllMaterials();
        //    dgvList.DataSource = lstMC;

        //    Dialogs.PopUPDialog d = new Dialogs.PopUPDialog("Saved Successfully!");
        //    d.ShowDialog();
        }
    }
}
