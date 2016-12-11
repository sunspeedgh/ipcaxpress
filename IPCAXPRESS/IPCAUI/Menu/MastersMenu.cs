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
    public partial class MastersMenu : DevExpress.XtraEditors.XtraForm
    {
        XtraForm1 frm;
        public MastersMenu(XtraForm1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void MastersMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Visible = true;
        }
    }
}