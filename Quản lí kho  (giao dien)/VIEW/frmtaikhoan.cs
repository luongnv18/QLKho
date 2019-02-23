using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lí_kho___giao_dien_.VIEW
{
    public partial class frmtaikhoan : Form
    {
        public frmtaikhoan()
        {
            InitializeComponent();
        }

        private string connectstr = @"Data Source=SKY_COMPUTER\SQLEXPRESS02;Initial Catalog = QLKHO; Integrated Security = True";
      

        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You really want to escape!", "Notification", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.Cancel)
            { e.Cancel = true; }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                string user = txtUsername.Text;
                string pass = txtPassword.Text;
                string query = " select * from ACOUNT WHERE USERNAME = N'" + txtUsername.Text + "'  AND PASS = '" + txtPassword.Text + "'AND RIGHTS = 'ADMIN'";
                using (SqlConnection sqlcn = new SqlConnection(connectstr))

                {
                    sqlcn.Open();
                    SqlCommand commad = new SqlCommand(query, sqlcn);
                    SqlDataReader data = commad.ExecuteReader();
                    if (data.Read() == true)
                    {
                        MessageBox.Show("Login  successed");
                        frmhethong f = new frmhethong();
                        this.Hide();
                        f.ShowDialog();
                    this.Close();

                    }
                    else
                    {
                        MessageBox.Show("You enter  incorrect informattion");
                    }

                }




            
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

        }
    }
}
