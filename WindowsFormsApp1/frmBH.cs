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
    public partial class frmBH : Form
    {
        public int selectedname;
        public frmBH()
        {
            InitializeComponent();
            dgvListProduct.AutoGenerateColumns = false;
        }

        private void frmBH_Load(object sender, EventArgs e)
        {
            dgvListProduct.DataSource = ProductBUS.GetProduct();
            cboStaffName.DataSource = AccountBUS.GetAccount();
            cboStaffName.DisplayMember = "HOTEN";
            cboStaffName.ValueMember = "MANV";
            txtStaffName.Text = frmDangNhap.fullname.ToString();
            lblManv.Text = frmDangNhap.manv.ToString();
            txtCode.Text = GenerateInvoiceCode();
        }

        private string GenerateInvoiceCode()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void dgvListProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvListProduct.SelectedRows[0];
            if (Convert.ToInt32(selectedRow.Cells["colStock"].Value) != 0)
            {
                string id = Convert.ToString(selectedRow.Cells["colPId"].Value);
                string name = selectedRow.Cells["colProductName"].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells["colPrice"].Value);
                int search = CheckCartExist(id);
                if (search == -1)
                {
                    dgvListInvoice.Rows.Add(id, name, 1, price);
                }
                else if (Convert.ToInt32(dgvListProduct.SelectedRows[0].Cells["colStock"].Value) > Convert.ToInt32(dgvListInvoice.Rows[search].Cells["colIQ"].Value))
                {
                    int qty = Convert.ToInt32(dgvListInvoice.Rows[search].Cells["colIQ"].Value) + 1;
                    dgvListInvoice.Rows[search].Cells["colIQ"].Value = qty;
                }
                else
                {
                    MessageBox.Show("Vượt quá SLTK", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                    
                lblTotal.Text = CaculateTotal().ToString();

            }
        }

        private int CheckCartExist(string masach)
        {
            foreach (DataGridViewRow row in dgvListInvoice.Rows)
            {
                if (row.Cells["colID"].Value.ToString() == masach)
                {
                    return row.Index;
                }
            }
            return -1;
        }

        private decimal CaculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvListInvoice.Rows)
            {
                int qty = Convert.ToInt32(row.Cells["colIQ"].Value);
                decimal unitPrice = Convert.ToDecimal(row.Cells["colIUP"].Value);
                total += qty * unitPrice;
            }
            return total;
        }

        private void frmBH_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvListInvoice.Rows.Count != 0)
                {
                    int rowIndex = dgvListInvoice.CurrentCell.RowIndex;
                    decimal rowPrice = Convert.ToDecimal(dgvListInvoice.CurrentRow.Cells["colIUP"].Value);
                    int rowQty = Convert.ToInt32(dgvListInvoice.CurrentRow.Cells["colIQ"].Value);
                    decimal total = Convert.ToDecimal(lblTotal.Text);
                    dgvListInvoice.Rows.RemoveAt(rowIndex);
                    total -= rowPrice * rowQty;
                    lblTotal.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("Không thể xoá vì không có dữ liệu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }    
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            dgvListInvoice.Rows.Clear();
            lblTotal.Text = "0.000";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvListInvoice.Rows.Count == 0)
                {
                    MessageBox.Show("Không thể thanh toán vì không có sản phẩm trong hoá đơn", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    InvoiceSale invoice = new InvoiceSale
                    {
                        MAHD = txtCode.Text,
                        //MANV = cboStaffName.SelectedValue.ToString(),
                        MANV = lblManv.Text.ToString(),
                        THOIGIAN = DateTime.Now,
                        TONGTIEN = CaculateTotal(),
                        TRANGTHAI = true
                    };
                    if (InvoiceSaleBUS.Add(invoice))
                    {
                        MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        dgvListProduct.DataSource = ProductBUS.GetProduct();
                    }

                    //InvoiceSaleBUS.Add(invoice);
                    dgvListProduct.DataSource = ProductBUS.GetProduct();
                    /*if (InvoiceSaleBUS.Add(invoice))
                    {
                        MessageBox.Show("Thanh toán thành công");
                        dgvListProduct.DataSource = ProductBUS.GetProduct();
                    }*/
                    invoice = InvoiceSaleBUS.GetByMAHD(invoice.MAHD);
                    foreach (DataGridViewRow row in dgvListInvoice.Rows)
                    {
                        InvoiceSaleDetail invoiceSaleDetail = new InvoiceSaleDetail
                        {
                            MAHD = invoice.MAHD,
                            MASACH = row.Cells["colID"].Value.ToString(),
                            GIATIEN = Convert.ToDecimal(row.Cells["colIUP"].Value),
                            SL = Convert.ToInt32(row.Cells["colIQ"].Value)
                        };
                        InvoiceSaleDetailBUS.Add(invoiceSaleDetail);
                        ProductBUS.SubtrackStock(invoiceSaleDetail.MASACH, invoiceSaleDetail.SL);
                    }
                    dgvListInvoice.Rows.Clear();
                    dgvListProduct.DataSource = ProductBUS.GetProduct();
                    txtCode.Text = GenerateInvoiceCode();
                    lblTotal.Text = "0.000";
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           dgvListProduct.DataSource = ProductBUS.GetByName(txtSearch.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "Tìm kiếm...";
            dgvListProduct.DataSource = ProductBUS.GetProduct();
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void dgvListProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvListProduct.Columns["colImage"].Index)
            {
                e.Value = Image.FromFile(@"images\" + e.Value);
            }
        }
}
}
