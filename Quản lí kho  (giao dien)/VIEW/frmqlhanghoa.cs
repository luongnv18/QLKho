using BUS;
using Quản_lí_kho___giao_dien_.DTO;
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
    public partial class frm_ManageAccount : Form
    {
        public frm_ManageAccount()
        {
            InitializeComponent();
           // string connectstr = @"Data Source = DESSTOP-64NJ88P\DIEM98; Initial Catalog =QLKHO; Integrated Security=True";
          //  SqlConnection connection = new SqlConnection();
           // string query = "select *from dbo.HANGHOA";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void frmqlhanghoa_Load(object sender, EventArgs e)
        {

            List<Account_DTO> list = Acount_BUS.Load_Account();
                dgv_manageAccount.DataSource = list;
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
                if (txtId.Text == "" || txtFullname.Text == "" || txtPassword.Text == ""||txtRight.Text==""||txtId.Text=="")
                {
                    MessageBox.Show("Vui  lòng nhập đầy đủ thông tin ", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    //tạo đói tượng phòng ban để gán dữ  liệu
                    Account_DTO a = new Account_DTO();
                    a.Id = txtId.Text;
                    a.Username = txtUsername.Text;
                a.Fullname = txtFullname.Text;
                a.Password = txtPassword.Text;
                a.Right = txtRight.Text;

                Acount_BUS.Add_ac(a);
                    if (Acount_BUS.Add_ac(a) == true)
                    {

                        MessageBox.Show("Thêm thành công!");
                        dgv_manageAccount.Refresh();
                        return;
                    }
                    MessageBox.Show("Thêm thất bại ");
                }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            

                if (txtId.Text == "" || txtFullname.Text == "" || txtPassword.Text == "" || txtRight.Text == "" || txtId.Text == "")
                {
                    MessageBox.Show("Vui  lòng nhập đầy đủ thông tin ", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    //tạo đói tượng phòng ban để gán dữ  liệu
                    Account_DTO a = new Account_DTO();
                    a.Id = txtId.Text;
                    a.Username = txtUsername.Text;
                    a.Fullname = txtFullname.Text;
                    a.Password = txtPassword.Text;
                    a.Right = txtRight.Text;

                    Acount_BUS.Edit_ac(a);
                    if (Acount_BUS.Edit_ac(a) == true)
                    {

                        MessageBox.Show("Sửa  thành công!");
                        dgv_manageAccount.Refresh();
                        return;
                    }
                    MessageBox.Show("Sửa thất bại ");
                }

            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           

                if (txtId.Text == "" || txtFullname.Text == "" || txtPassword.Text == "" || txtRight.Text == "" || txtId.Text == "")
                {
                    MessageBox.Show("Vui  lòng nhập đầy đủ thông tin ", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    //tạo đói tượng phòng ban để gán dữ  liệu
                    Account_DTO a = new Account_DTO();
                    a.Id = txtId.Text;
                    a.Username = txtUsername.Text;
                    a.Fullname = txtFullname.Text;
                    a.Password = txtPassword.Text;
                    a.Right = txtRight.Text;

                    Acount_BUS.Delete_ac(a);
                    if (Acount_BUS.Delete_ac(a) == true)
                    {

                        MessageBox.Show("Xóa thành công!");
                        dgv_manageAccount.Refresh();
                        return;
                    }
                    MessageBox.Show("Xóa thất bại ");
                }

            
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
           
                if (txtId.Text == "")
                {
                    MessageBox.Show("Nhập user  cần tìm kiếm!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                Account_DTO a = new Account_DTO();
              a.Id = txtId.Text.ToString();
                List<Account_DTO> list = Acount_BUS.Load_Acount_find(a);
                dgv_manageAccount.DataSource = list;
                if (list == null)

                    MessageBox.Show("user  bạn tìm kiếm không tồn tại ", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.None);

            }

        private void dgv_manageAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                int n = e.RowIndex;
                txtId.Text = dgv_manageAccount.Rows[n].Cells[0].Value.ToString();
                txtUsername.Text = dgv_manageAccount.Rows[n].Cells[1].Value.ToString();
               txtFullname.Text = dgv_manageAccount.Rows[n].Cells[2].Value.ToString();
               txtRight.Text = dgv_manageAccount.Rows[n].Cells[3].Value.ToString();
            txtPassword.Text = dgv_manageAccount.Rows[n].Cells[4].Value.ToString();


        }
    }
}
