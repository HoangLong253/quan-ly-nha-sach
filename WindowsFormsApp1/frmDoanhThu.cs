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
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            dgvStatistics.DataSource = InvoiceSaleBUS.GetStat();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            //dgvStatistics.DataSource = InvoiceSaleBUS.GetByDayEnH(txtDay.Text, txtMonth.Text, txtYear.Text);
        }

        /**/

        private void frmDoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*if (txtDay.Text != "" && txtMonth.Text != "" && txtYear.Text != "")
            {
                dgvStatistics.DataSource = InvoiceSaleBUS.GetByDayEnH(txtDay.Text, txtMonth.Text, txtYear.Text);
                dgvTotal.DataSource = InvoiceSaleBUS.GetByDayTotal(txtDay.Text, txtMonth.Text, txtYear.Text);
            }
            else if (txtMonth.Text != "" && txtYear.Text != "")
            {
                dgvStatistics.DataSource = InvoiceSaleBUS.GetByMonthEnH(txtMonth.Text, txtYear.Text);
                dgvTotal.DataSource = InvoiceSaleBUS.GetByMonthTotal(txtMonth.Text, txtYear.Text);
            }
            else if (txtYear.Text != "")
            {
                dgvStatistics.DataSource = InvoiceSaleBUS.GetByYearEnH(txtYear.Text);
                dgvTotal.DataSource = InvoiceSaleBUS.GetByYearTotal(txtYear.Text);
            }
            else if (txtDay.Text != "" && txtMonth.Text == "" && txtYear.Text != "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }*/
            
            if ((txtDay.Text == "" && txtMonth.Text == "" && txtYear.Text == "") || (txtDay.Text != "" && txtMonth.Text == "" && txtYear.Text != "") || (txtDay.Text != "" && txtMonth.Text == "" && txtYear.Text == "") || (txtDay.Text == "" && txtMonth.Text != "" && txtYear.Text == "") || (txtDay.Text != "" && txtMonth.Text != "" && txtYear.Text == ""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }  
            else if (txtDay.Text != "" && txtMonth.Text != "" && txtYear.Text != "")
            {
                dgvStatistics.DataSource = InvoiceSaleBUS.GetByDayEnH(txtDay.Text, txtMonth.Text, txtYear.Text);
                dgvTotal.DataSource = InvoiceSaleBUS.GetByDayTotal(txtDay.Text, txtMonth.Text, txtYear.Text);
            }
            else if (txtMonth.Text != "" && txtYear.Text != "")
            {
                dgvStatistics.DataSource = InvoiceSaleBUS.GetByMonthEnH(txtMonth.Text, txtYear.Text);
                dgvTotal.DataSource = InvoiceSaleBUS.GetByMonthTotal(txtMonth.Text, txtYear.Text);
            }
            else if (txtYear.Text != "")
            {
                dgvStatistics.DataSource = InvoiceSaleBUS.GetByYearEnH(txtYear.Text);
                dgvTotal.DataSource = InvoiceSaleBUS.GetByYearTotal(txtYear.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.frmDoanhThu_Load(sender, e);
            txtDay.Text = "";
            txtYear.Text = "";
            txtMonth.Text = "";
        }
    }
}
