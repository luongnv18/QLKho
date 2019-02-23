using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lí_kho___giao_dien_.VIEW
{
    public partial class frmhethong : Form
    {
        public frmhethong()
        {
            InitializeComponent();
        }

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ManageAccount f = new frm_ManageAccount();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
