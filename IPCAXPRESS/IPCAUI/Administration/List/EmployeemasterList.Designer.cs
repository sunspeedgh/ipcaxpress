﻿namespace IPCAUI.Administration.List
{
    partial class EmployeemasterList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dvgEmployeemstList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.employeemstList = new IPCAUI.DataSets.EmployeemstList();
            this.employeemstListDtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJoiningDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmployeemstList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeemstList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeemstListDtBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dvgEmployeemstList);
            this.layoutControl1.Controls.Add(this.navBarControl1);
            this.layoutControl1.Controls.Add(this.textEdit4);
            this.layoutControl1.Controls.Add(this.textEdit3);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(573, 260, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(841, 480);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Location = new System.Drawing.Point(12, 12);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 146;
            this.navBarControl1.Size = new System.Drawing.Size(146, 456);
            this.navBarControl1.TabIndex = 8;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.NavigationPaneViewInfoRegistrator();
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Options";
            this.navBarGroup1.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupClientHeight = 312;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.treeList1);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(144, 339);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.BeginUnboundLoad();
            this.treeList1.AppendNode(new object[] {
            "Email"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Print"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Export"}, -1);
            this.treeList1.AppendNode(new object[] {
            "Refresh"}, -1);
            this.treeList1.EndUnboundLoad();
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.Size = new System.Drawing.Size(144, 339);
            this.treeList1.TabIndex = 0;
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "treeListColumn1";
            this.treeListColumn1.FieldName = "treeListColumn1";
            this.treeListColumn1.MinWidth = 34;
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "navBarGroup2";
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(258, 12);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Size = new System.Drawing.Size(60, 20);
            this.textEdit4.StyleController = this.layoutControl1;
            this.textEdit4.TabIndex = 4;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(418, 12);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Size = new System.Drawing.Size(411, 20);
            this.textEdit3.StyleController = this.layoutControl1;
            this.textEdit3.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(841, 480);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEdit4;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(150, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(160, 24);
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEdit3;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(310, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(511, 24);
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.navBarControl1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(150, 460);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // dvgEmployeemstList
            // 
            this.dvgEmployeemstList.DataSource = this.employeemstListDtBindingSource;
            this.dvgEmployeemstList.Location = new System.Drawing.Point(162, 36);
            this.dvgEmployeemstList.MainView = this.gridView1;
            this.dvgEmployeemstList.Name = "dvgEmployeemstList";
            this.dvgEmployeemstList.Size = new System.Drawing.Size(667, 432);
            this.dvgEmployeemstList.TabIndex = 9;
            this.dvgEmployeemstList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dvgEmployeemstList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dvgEmployeemstList_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colEmployeeCode,
            this.colParentGroup,
            this.colJoiningDate});
            this.gridView1.GridControl = this.dvgEmployeemstList;
            this.gridView1.Name = "gridView1";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.dvgEmployeemstList;
            this.layoutControlItem3.Location = new System.Drawing.Point(150, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(671, 436);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // employeemstList
            // 
            this.employeemstList.DataSetName = "EmployeemstList";
            this.employeemstList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeemstListDtBindingSource
            // 
            this.employeemstListDtBindingSource.DataMember = "EmployeemstListDt";
            this.employeemstListDtBindingSource.DataSource = this.employeemstList;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colEmployeeCode
            // 
            this.colEmployeeCode.FieldName = "Employee Code";
            this.colEmployeeCode.Name = "colEmployeeCode";
            this.colEmployeeCode.Visible = true;
            this.colEmployeeCode.VisibleIndex = 1;
            // 
            // colParentGroup
            // 
            this.colParentGroup.FieldName = "Parent Group";
            this.colParentGroup.Name = "colParentGroup";
            this.colParentGroup.Visible = true;
            this.colParentGroup.VisibleIndex = 2;
            // 
            // colJoiningDate
            // 
            this.colJoiningDate.FieldName = "Joining Date";
            this.colJoiningDate.Name = "colJoiningDate";
            this.colJoiningDate.Visible = true;
            this.colJoiningDate.VisibleIndex = 3;
            // 
            // EmployeemasterList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 480);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeemasterList";
            this.Text = "Employee Master List";
            this.Load += new System.EventHandler(this.EmployeemasterList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEmployeemstList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeemstList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeemstListDtBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraGrid.GridControl dvgEmployeemstList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.BindingSource employeemstListDtBindingSource;
        private DataSets.EmployeemstList employeemstList;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeCode;
        private DevExpress.XtraGrid.Columns.GridColumn colParentGroup;
        private DevExpress.XtraGrid.Columns.GridColumn colJoiningDate;
    }
}