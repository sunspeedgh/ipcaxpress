﻿using System;
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
    public partial class Employeegroup : Form
    {
        public Employeegroup()
        {
            InitializeComponent();
        }

        private void ListEmployeegrp_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Administration.List.EmployeegrpList frmList = new Administration.List.EmployeegrpList();
            frmList.StartPosition = FormStartPosition.CenterScreen;

            frmList.ShowDialog();
        }
    }
}
