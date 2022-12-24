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
    public partial class frmTrangchu : Form
    {
        public frmTrangchu()
        {
            InitializeComponent();
        }
        private int count = 1;
        private void frmTrangchu_Load(object sender, EventArgs e)
        {
            this.frmTrangchu_SizeChanged(sender, e);
            //this.WindowState = FormWindowState.Maximized;
            if (frmDangNhap.CheckLogin==0)
            {
                lblDisplayName.Text = frmDangNhap.fullname;
                thốngKêToolStripMenuItem.Enabled = false;
                nhânViênToolStripMenuItem.Enabled = false;
                sảnPhẩmToolStripMenuItem.Enabled = false;
                loạiSảnPhẩmToolStripMenuItem.Enabled = false;
                nhậpToolStripMenuItem.Enabled = false;
                frmBH f = new frmBH();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (frmDangNhap.CheckLogin == 1)
            {
                lblDisplayName.Text = frmDangNhap.fullname;
                thốngKêToolStripMenuItem.Enabled = true;
            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBH fBH = new frmBH();
            frmTrangchu fTC = new frmTrangchu();
            fTC.Visible = false;
            fBH.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLTK fTK = new frmQLTK();
            fTK.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLSP fSP = new frmQLSP();
            fSP.ShowDialog();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLLSP fLSP = new frmQLLSP();
            fLSP.ShowDialog();
        }

        private void top10SPBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTop10 fT10 = new frmTop10();
            fT10.ShowDialog();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoanhThu fS = new frmDoanhThu();
            fS.ShowDialog();
        }

        private void frmTrangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }*/
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmDangNhap fDN = new frmDangNhap();
                this.Hide();
                fDN.ShowDialog();
            }
        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDN fHDN = new frmHDN();
            fHDN.ShowDialog();
        }

        private void bánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHDB fHDB = new frmHDB();
            fHDB.ShowDialog();
        }

        private void frmTrangchu_MaximumSizeChanged(object sender, EventArgs e)
        {
            label1.Location = new Point(1290);
            lblDisplayName.Location = new Point(1361);
        }

        private void frmTrangchu_MaximizedBoundsChanged(object sender, EventArgs e)
        {
            label1.Location = new Point(1290);
            lblDisplayName.Location = new Point(1361);
        }

        private void frmTrangchu_SizeChanged(object sender, EventArgs e)
        {
            int temp = Convert.ToInt32(frmDangNhap.manv);
            switch (temp)
            {
                case 1:
                    {
                        if (count % 2 != 0)
                        {
                            
                            label1.Location = new Point(539, 36);
                            lblDisplayName.Location = new Point(610, 36);
                            count++;
                        }
                        else
                        {
                            label1.Location = new Point(1111, 36);
                            lblDisplayName.Location = new Point(1192, 36);
                            count++;
                        }
                    }
                    break;
                case 2:
                    {
                        if (count % 2 != 0)
                        {
                            label1.Location = new Point(615, 36);
                            lblDisplayName.Location = new Point(686, 36);
                            count++;
                        }
                        else
                        {
                            label1.Location = new Point(1195, 36);
                            lblDisplayName.Location = new Point(1266, 36);
                            count++;
                        }
                        break;
                    }
                case 3:
                    {
                        if (count % 2 != 0)
                        {
                            label1.Location = new Point(612, 36);
                            lblDisplayName.Location = new Point(683, 36);
                            count++;
                        }
                        else
                        {
                            label1.Location = new Point(1195, 36);
                            lblDisplayName.Location = new Point(1266, 36);
                            count++;
                        }
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
