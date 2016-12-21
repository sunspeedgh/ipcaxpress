using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eSunSpeedDomain;
using eSunSpeed.BusinessLogic;

namespace IPCAUI.Administration
{
    public partial class Executivegroup : Form
    {
        ExecutivegroupBL objexe = new ExecutivegroupBL();
        public Executivegroup()
        {
            InitializeComponent();
        }

        public bool isSuccess { get; private set; }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //TODO: 1. Check whether the group name exists or not
            //2. if exist then do not allow to save with the same group name
            //3. Prompt user to change the group name as it already exists

            if (tbxName.Text.Equals(string.Empty))
            {
                MessageBox.Show("Group Name can not be blank!");
                return;
            }

            //if (accObj.IsGroupExists(tbxGroupName.Text.Trim()))
            //{
            //    MessageBox.Show("Group Name already Exists!", "SunSpeed", MessageBoxButtons.RetryCancel);
            //    cbxUnderGrp.Focus();
            //    return;
            //}

            
           

            eSunSpeedDomain.ExecutiveModel objexemod = new ExecutiveModel();
            objexemod.Name = tbxName.Text;

            //   objexe.Primary = cbxPrimarygroup.SelectedItem.ToString();

            objexemod.Alias = tbxAliasname.Text;
            objexemod.PrintName = tbxPrintname.Text;
            objexemod.Address = tbxAddress.Text;
            objexemod.Address1 = tbxAddress1.Text;
            objexemod.Address2 = tbxAddress2.Text;
            objexemod.Address3 = tbxAddress3.Text;
            objexemod.TelephoneNumber = tbxTelnumber.Text;
            objexemod.MobileNumber = Convert.ToInt32(tbxMobileno.Text.Trim());
            objexemod.HandlescallType = tbxhandlecalltype.Text;
            objexemod.CreatedBy = "Admin";

            string message = string.Empty;
                       
            bool issuccess = objexe.SaveExeGroup(objexemod);
            if (isSuccess)
            {
                MessageBox.Show("Saved Successfully!");
            }
           

        }

        private void SJKS(object sender, EventArgs e)
        {

        }

        private void AD(object sender, EventArgs e)
        {

        }

        private void ListExecutivemaster_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Administration.List.ExecutivemasterList frmList = new Administration.List.ExecutivemasterList();
            frmList.StartPosition = FormStartPosition.CenterScreen;

            frmList.ShowDialog();
        }
    }
}