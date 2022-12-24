using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class frmTop10 : Form
    {
        public frmTop10()
        {
            InitializeComponent();
            dgvTop10.AutoGenerateColumns = false;
        }

        private void dgvTop10_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvTop10.Columns["colImage"].Index)
            {
                e.Value = Image.FromFile(@"images\" + e.Value);
            }
        }

        private void frmTop10_Load(object sender, EventArgs e)
        {
            dgvTop10.DataSource = ProductBUS.TOP10();
        }

        private void frmTop10_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
