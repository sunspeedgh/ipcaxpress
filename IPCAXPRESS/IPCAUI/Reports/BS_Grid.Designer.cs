namespace IPCAUI.Reports
{
    partial class BS_Grid
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
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridSplitContainer1Grid = new DevExpress.XtraGrid.GridControl();
            this.approversBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPCADataSet = new IPCAUI.IPCADataSet();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPCADataSet1 = new IPCAUI.IPCADataSet1();
            this.approversTableAdapter = new IPCAUI.IPCADataSetTableAdapters.ApproversTableAdapter();
            this.customerTableAdapter = new IPCAUI.IPCADataSet1TableAdapters.CustomerTableAdapter();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bandedGridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bandedGridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.approversBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Grid = this.gridSplitContainer1Grid;
            this.gridSplitContainer1.Location = new System.Drawing.Point(201, 21);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridSplitContainer1Grid);
            this.gridSplitContainer1.Panel1.Text = "Panel1";
            this.gridSplitContainer1.Panel2.Text = "Panel2";
            this.gridSplitContainer1.Size = new System.Drawing.Size(400, 400);
            this.gridSplitContainer1.TabIndex = 0;
            this.gridSplitContainer1.Text = "gridSplitContainer1";
            // 
            // gridSplitContainer1Grid
            // 
            this.gridSplitContainer1Grid.DataSource = this.approversBindingSource;
            this.gridSplitContainer1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1Grid.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1Grid.MainView = this.gridView1;
            this.gridSplitContainer1Grid.Name = "gridSplitContainer1Grid";
            this.gridSplitContainer1Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gridSplitContainer1Grid.Size = new System.Drawing.Size(400, 400);
            this.gridSplitContainer1Grid.TabIndex = 0;
            this.gridSplitContainer1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridSplitContainer1Grid.Click += new System.EventHandler(this.gridSplitContainer1Grid_Click);
            // 
            // approversBindingSource
            // 
            this.approversBindingSource.DataMember = "Approvers";
            this.approversBindingSource.DataSource = this.iPCADataSet;
            // 
            // iPCADataSet
            // 
            this.iPCADataSet.DataSetName = "IPCADataSet";
            this.iPCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.iPCADataSet1;
            // 
            // iPCADataSet1
            // 
            this.iPCADataSet1.DataSetName = "IPCADataSet1";
            this.iPCADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // approversTableAdapter
            // 
            this.approversTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.bandedGridColumn1,
            this.bandedGridColumn2,
            this.bandedGridColumn3,
            this.bandedGridColumn4,
            this.bandedGridColumn5,
            this.bandedGridColumn6,
            this.bandedGridColumn7,
            this.bandedGridColumn8});
            this.gridView1.GridControl = this.gridSplitContainer1Grid;
            this.gridView1.Name = "gridView1";
            // 
            // bandedGridColumn1
            // 
            this.bandedGridColumn1.ColumnEdit = this.repositoryItemComboBox1;
            this.bandedGridColumn1.FieldName = "Address";
            this.bandedGridColumn1.Name = "bandedGridColumn1";
            this.bandedGridColumn1.Visible = true;
            this.bandedGridColumn1.VisibleIndex = 0;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.FieldName = "ApproverName";
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            this.bandedGridColumn2.Visible = true;
            this.bandedGridColumn2.VisibleIndex = 1;
            // 
            // bandedGridColumn3
            // 
            this.bandedGridColumn3.Name = "bandedGridColumn3";
            this.bandedGridColumn3.Visible = true;
            this.bandedGridColumn3.VisibleIndex = 2;
            // 
            // bandedGridColumn4
            // 
            this.bandedGridColumn4.Name = "bandedGridColumn4";
            this.bandedGridColumn4.Visible = true;
            this.bandedGridColumn4.VisibleIndex = 3;
            // 
            // bandedGridColumn5
            // 
            this.bandedGridColumn5.FieldName = "City";
            this.bandedGridColumn5.Name = "bandedGridColumn5";
            this.bandedGridColumn5.Visible = true;
            this.bandedGridColumn5.VisibleIndex = 4;
            // 
            // bandedGridColumn6
            // 
            this.bandedGridColumn6.FieldName = "CustomerID";
            this.bandedGridColumn6.Name = "bandedGridColumn6";
            this.bandedGridColumn6.Visible = true;
            this.bandedGridColumn6.VisibleIndex = 5;
            // 
            // bandedGridColumn7
            // 
            this.bandedGridColumn7.FieldName = "ApproverName";
            this.bandedGridColumn7.Name = "bandedGridColumn7";
            this.bandedGridColumn7.Visible = true;
            this.bandedGridColumn7.VisibleIndex = 6;
            // 
            // bandedGridColumn8
            // 
            this.bandedGridColumn8.FieldName = "Mobile";
            this.bandedGridColumn8.Name = "bandedGridColumn8";
            this.bandedGridColumn8.Visible = true;
            this.bandedGridColumn8.VisibleIndex = 7;
            // 
            // BS_Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 418);
            this.Controls.Add(this.gridSplitContainer1);
            this.Name = "BS_Grid";
            this.Text = "BS_Grid";
            this.Load += new System.EventHandler(this.BS_Grid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.approversBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPCADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridSplitContainer1Grid;
        private IPCADataSet iPCADataSet;
        private System.Windows.Forms.BindingSource approversBindingSource;
        private IPCADataSetTableAdapters.ApproversTableAdapter approversTableAdapter;
        private IPCADataSet1 iPCADataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private IPCADataSet1TableAdapters.CustomerTableAdapter customerTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn bandedGridColumn8;
    }
}