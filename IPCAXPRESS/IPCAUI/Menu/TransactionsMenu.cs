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

namespace IPCAUI.Menu
{
    public partial class TransactionsMenu : DevExpress.XtraEditors.XtraForm
    {
        XtraForm1 frm;
        public TransactionsMenu(XtraForm1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void TransactionsMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Visible = true;
        }
    }
}