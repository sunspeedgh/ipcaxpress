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
using DevExpress.XtraTreeList;

namespace IPCAUI.Reports.Accountbooks.Grids
{
    public partial class ProfitLossGrd : DevExpress.XtraEditors.XtraForm
    {
        public ProfitLossGrd()
        {
            InitializeComponent();
        }
       
        private void Fill()
        {

            DataSets.ProfitLossDs.ProfitLossDtDataTable dt = new DataSets.ProfitLossDs.ProfitLossDtDataTable();
            dt.Columns.Add("Test1");
            dt.Columns.Add("Test2");

            DataSets.ProfitLossDs.ProfitLossDtRow dr = dt.NewProfitLossDtRow();

            dr[0] = "Opening Stock         0.00";
            dr[1] = "Closing Stock         0.00";
            dr[2] = "Opening Stock         0.00";
            dr[3] = "Closing Stock         0.00";

            dt.AddProfitLossDtRow(dr);

            DataSets.BalanceSheet ds = new DataSets.BalanceSheet();
            ds.Tables.Clear();

            ds.Tables.Add(dt);

            BindingSource src = new BindingSource();
            src.DataSource = ds.Tables[0];

            //Following code is used to dynamically add columns to grid and fill values
            gdvProfitLoss.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
            gdvProfitLoss.Columns[2].Visible = true;
            gdvProfitLoss.Columns[2].FieldName = "Test1";

            gdvProfitLoss.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
            gdvProfitLoss.Columns[3].Visible = true;
            gdvProfitLoss.Columns[3].FieldName = "Test2";

            profitLossDtBindingSource.DataSource = src;

        }
    
        private void ProfitLossGrd_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void rptOptions_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            int selectedNodeId = (sender as TreeList).FocusedNode.Id;
            Reports.Accountbooks.ProfitLossAc frmPL;

            switch (selectedNodeId)
            {              
                case 1:
                    frmPL = new ProfitLossAc("Month","Horizontal");
                    frmPL.ShowDialog();
                    break;
                case 2:
                    frmPL = new ProfitLossAc("Date", "Horizontal");
                    frmPL.ShowDialog();
                    break;
                case 4:
                    frmPL = new ProfitLossAc("Month", "Vertical");
                    frmPL.ShowDialog();
                    break;
                case 5:
                    frmPL = new ProfitLossAc("Date", "Vertical");
                    frmPL.ShowDialog();
                    break;
                case 7:
                    //Reports.AccountSummary.DailySummary frmDaily = new AccountSummary.DailySummary();
                    //frmDaily.ShowDialog();
                    break;
                case 8:
                    //Reports.AccountSummary.DailySummary frmDaily = new AccountSummary.DailySummary();
                    //frmDaily.ShowDialog();
                    break;
                case 9:
                    frmPL = new ProfitLossAc("", "Summary");
                    frmPL.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }

}