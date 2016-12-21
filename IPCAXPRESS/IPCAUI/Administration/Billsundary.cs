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
using eSunSpeedDomain;
using eSunSpeed.BusinessLogic;

namespace IPCAUI.Administration
{
    public partial class Billsundary : DevExpress.XtraEditors.XtraForm
    {
        public Billsundary()
        {
            InitializeComponent();
        }

        private void Billsundary_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            //TODO: 1. Check whether the group name exists or not
            //2. if exist then do not allow to save with the same group name
            //3. Prompt user to change the group name as it already exists

           if (tbxName.Text.Equals(string.Empty))

            {
                MessageBox.Show("Group Name can not be blank!");
                return;
            }


            //}

            //if (accObj.IsGroupExists(tbxGroupName.Text.Trim()))
            //{
            //    MessageBox.Show("Group Name already Exists!", "SunSpeed", MessageBoxButtons.RetryCancel);
            //    cbxUnderGrp.Focus();
            //    return;
            //}

            eSunSpeedDomain.BillSundryMasterModel objbsmod = new eSunSpeedDomain.BillSundryMasterModel();
            objbsmod.Name = tbxName.Text;
            objbsmod.Alias = cbxalias.Text;
            objbsmod.BillSundryType = tbxbillsundrytype.Text;
            objbsmod.BillSundryNature = tbxbillsundrynarration.Text;
            objbsmod.DefaultValue = tbxdefaultvalue.Text;
            objbsmod.AffectstheCostofGoodsinStockTransfer =Convert.ToBoolean(tbxaffectsthecostofggodsinstoclktransfer.Text.Trim());
            objbsmod.AffectstheCostofGoodsinSale = tbxaffectsthecostofgoodsinsle.Text;
            objbsmod.AffectstheCostofGoodsinPurchase = tbxaffectsthecostofgoodsinpurchase.Text;
            objbsmod.AffectstheCostofGoodsinMaterialIssue= tbxaffectsthecostoofgoodsinmaterialissue.Text;
            objbsmod.AffectstheCostofGoodsinMaterialIssue = tbxaffectsthecostoofgoodsinmaterialissue.Text;





            //objContGroup.Primary = cbxPrimarygroup.SelectedItem.ToString();

            // objContGroup.UnderGroup = cbxUndergroup.SelectedItem.ToString();

            objbsmod.CreatedBy = "Admin";

                string message = string.Empty;
           // bool isSuccess = objcont.SaveContactGroup(objContGroup);

            bool isSuccess = objbsmod.SaveBSM(objbsmod);
             //   if (isSuccess)
                {
                    MessageBox.Show("Saved Successfully!");
                }
                //List<eSunSpeedDomain.AccountGroupModel> lstGroups = accObj.GetListofAccountsGroups();
                //dgvList.DataSource = lstGroups;

                //Dialogs.PopUPDialog d = new Dialogs.PopUPDialog("Saved Successfully!");
                //d.ShowDialog();

            }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

        }
    }
    }

