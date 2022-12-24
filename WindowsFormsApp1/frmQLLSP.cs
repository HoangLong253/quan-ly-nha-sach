using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmQLLSP : Form
    {
        private int selectedid = new int();
        public frmQLLSP()
        {
            InitializeComponent();
            dgvProductType.AutoGenerateColumns = false;
        }

        private void frmQLLSP_Load(object sender, EventArgs e)
        {
            dgvProductType.DataSource = ProductTypeBUS.GetProductType();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txtProductTypeID.Text == "" || txtProductTypeID.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    ProductType PT = GetFormData();
                    if (ProductTypeBUS.AddProductType(PT))
                    {
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        dgvProductType.DataSource = ProductTypeBUS.GetProductType();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       private ProductType GetFormData()
        {
            return new ProductType
            {
                MALOAISACH = Convert.ToInt32(txtProductTypeID.Text),
                LOAISACH = txtNameProductType.Text
            };
        }

        private void ClearForm()
        {
            txtNameProductType.Text = "";
            txtProductTypeID.Text = "";
        }

        private void dgvProductType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedid = int.Parse(dgvProductType.SelectedRows[0].Cells["colProductTypeID"].Value.ToString());
            ProductType pt = ProductTypeBUS.Get(selectedid);
            txtProductTypeID.Text = Convert.ToString(pt.MALOAISACH);
            txtNameProductType.Text = pt.LOAISACH;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            selectedid = int.Parse(dgvProductType.SelectedRows[0].Cells["colProductTypeID"].Value.ToString());
            ProductType pt = GetFormData();
            if (MessageBox.Show("Bạn đang ghi đè dữ kiệu loại sách tồn tại, tiếp tục?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ProductTypeBUS.EditProductType(selectedid, pt))
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    ClearForm();
                    dgvProductType.DataSource = ProductTypeBUS.GetProductType();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                ClearForm();
                dgvProductType.DataSource = ProductTypeBUS.GetProductType();
            }
        }

        private void frmQLLSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtProductTypeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvProductType.DataSource = ProductTypeBUS.GetByName(txtSearch.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.frmQLLSP_Load(sender, e);
            txtNameProductType.Text = "";
            txtProductTypeID.Text = "";
            txtSearch.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.frmQLLSP_Load(sender, e);
            txtSearch.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int masach = int.Parse(dgvProductType.SelectedRows[0].Cells["colProductTypeID"].Value.ToString());
            if (MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ProductTypeBUS.DelProductType(masach))
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    dgvProductType.DataSource = ProductTypeBUS.GetProductType();
                }
                else
                {
                    MessageBox.Show("Xoá không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
