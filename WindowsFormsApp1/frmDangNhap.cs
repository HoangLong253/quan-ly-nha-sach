using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace WindowsFormsApp1
{
    public partial class frmDangNhap : Form
    {
        private int count = 1;

        public static string manv;  
        public static string fullname;
        public static int CheckLogin;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(AccountBUS.LoginAccount(txtUsername.Text,txtPassword.Text) == true)
            {
                string name = txtUsername.Text;
                fullname = AccountBUS.GetFullName(name);
                manv = AccountBUS.GetMANV(name);
                //name = txtUsername.Text;
                CheckLogin = AccountBUS.CheckAdmin(txtUsername.Text,txtPassword.Text);
                frmTrangchu f = new frmTrangchu();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }   
            else
            {
                MessageBox.Show("Nhập sai tên tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }*/
        }

        private void btnReveal_Click(object sender, EventArgs e)
        {   
            if (count % 2 != 0)
            {
                btnReveal.Image = Image.FromFile(@"images\func\eye.png");
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Focus();
                count++;
            }
            else
            {
                btnReveal.Image = Image.FromFile(@"images\func\eyes.png");
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Focus();
                count++;
            }
        }
    }
}
