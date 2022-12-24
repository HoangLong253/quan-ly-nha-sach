using System;
using BUS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace WindowsFormsApp1
{
    public partial class frmQLTK : Form
    {
        private string selectedmanv;
        public frmQLTK()
        {
            InitializeComponent();
            dgvAccount.AutoGenerateColumns = false;
        }

        private void frmQLTK_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = AccountBUS.GetAccount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string temp = dgvAccount.CurrentRow.Cells["colUsername"].Value.ToString();
                if (txtUsername.Text == temp)
                {
                    MessageBox.Show("Username đã tồn tại, vui lòng đổi username khác!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else if (txtID.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtAddress.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    Account account = GetFormData();
                    if (AccountBUS.AddAccount(account))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        ClearForm();
                        dgvAccount.DataSource = AccountBUS.GetAccount();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }    
            }
            else
            {
                dgvAccount.DataSource = AccountBUS.GetAccount();
            }
        }
        private Account GetFormData()
        {
            return new Account{
                MANV = txtID.Text,
                USERNAME = txtUsername.Text,
                MATKHAU = txtPassword.Text,
                HOTEN = txtName.Text,
                DIACHI = txtAddress.Text,
                SDT = txtPhone.Text,
                LaAdmin = chkIsAdmin.Checked
            };
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string manv = dgvAccount.SelectedRows[0].Cells["colID"].Value.ToString();  
            if (MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckHowManyAdmin() == 1 && Convert.ToBoolean(dgvAccount.CurrentRow.Cells["colRole"].Value) == true)
                {
                    MessageBox.Show("Xoá không thành công vì cần ít nhất 1 tài khoản admin");
                }
                else
                {
                    if (AccountBUS.DelAccount(manv))
                    {
                        dgvAccount.DataSource = AccountBUS.GetAccount();
                        ClearForm();
                        MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtAddress.Text = "";
            txtName.Text = "";
            txtID.Text = "";
            txtPassword.Text = "";
            txtPhone.Text = "";
            txtUsername.Text = "";
            chkIsAdmin.Checked = false;
        }

        private void dgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedmanv = dgvAccount.SelectedRows[0].Cells["colID"].Value.ToString();
            Account acc = AccountBUS.Get(selectedmanv);
            txtID.Text = acc.MANV;
            txtUsername.Text = acc.USERNAME;
            txtPassword.Text = acc.MATKHAU;
            txtName.Text = acc.HOTEN;
            txtPhone.Text = acc.SDT;
            txtAddress.Text = acc.DIACHI;
            chkIsAdmin.Checked = acc.LaAdmin;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Lưu ý, bạn đang ghi đè dữ kiệu nhân viên đã tồn tại. Tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (CheckHowManyAdmin() == 1 && Convert.ToBoolean(dgvAccount.CurrentRow.Cells["colRole"].Value) == true && chkIsAdmin.Checked == false)
                {
                    MessageBox.Show("Sửa không thành công vì cần ít nhất 1 tài khoản admin", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    selectedmanv = dgvAccount.SelectedRows[0].Cells["colID"].Value.ToString();
                    Account acc = GetFormData();
                    if (AccountBUS.Edit(selectedmanv, acc))
                    {
                        MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvAccount.DataSource = AccountBUS.GetAccount();
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
            }
        }

        private void frmQLTK_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
            dgvAccount.DataSource = AccountBUS.GetAccount();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAccount.DataSource = AccountBUS.GetByName(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.frmQLTK_Load(sender, e);
            txtSearch.Text = "";
        }

        private int CheckHowManyAdmin()
        {
            return AccountBUS.GetHowManyAdmin();
        }
    }
}
