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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void tbxQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorList_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Administration.List.AuthorList frmList = new Administration.List.AuthorList();
            frmList.StartPosition = FormStartPosition.CenterScreen;

            frmList.ShowDialog();
        }

        private void tbxSave_Click(object sender, EventArgs e)
        {

        }
    }
}
