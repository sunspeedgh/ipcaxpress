namespace IPCAUI
{
    partial class Reportsmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.finalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trialbalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finalToolStripMenuItem,
            this.trialbalanceToolStripMenuItem,
            this.accountBooksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // finalToolStripMenuItem
            // 
            this.finalToolStripMenuItem.Name = "finalToolStripMenuItem";
            this.finalToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.finalToolStripMenuItem.Text = "Finalresults";
            this.finalToolStripMenuItem.Click += new System.EventHandler(this.finalToolStripMenuItem_Click);
            // 
            // trialbalanceToolStripMenuItem
            // 
            this.trialbalanceToolStripMenuItem.Name = "trialbalanceToolStripMenuItem";
            this.trialbalanceToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.trialbalanceToolStripMenuItem.Text = "Trial Balance";
            this.trialbalanceToolStripMenuItem.Click += new System.EventHandler(this.trialbalanceToolStripMenuItem_Click);
            // 
            // accountBooksToolStripMenuItem
            // 
            this.accountBooksToolStripMenuItem.Name = "accountBooksToolStripMenuItem";
            this.accountBooksToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.accountBooksToolStripMenuItem.Text = "Account Books";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 24);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.listBoxControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(896, 593);
            this.splitContainerControl1.SplitterPosition = 144;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(144, 593);
            this.listBoxControl1.TabIndex = 0;
            // 
            // Reportsmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 617);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reportsmain";
            this.Text = "Reportsmain";
            this.Load += new System.EventHandler(this.Reportsmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem finalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trialbalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountBooksToolStripMenuItem;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
    }
}