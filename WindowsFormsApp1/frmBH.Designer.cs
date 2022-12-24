namespace WindowsFormsApp1
{
    partial class frmBH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBH));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvListInvoice = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIUP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.dgvListProduct = new System.Windows.Forms.DataGridView();
            this.colPId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cboStaffName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblManv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSearch.Location = new System.Drawing.Point(13, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Tìm kiếm...";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(169, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // dgvListInvoice
            // 
            this.dgvListInvoice.AllowUserToAddRows = false;
            this.dgvListInvoice.AllowUserToDeleteRows = false;
            this.dgvListInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colIPN,
            this.colIQ,
            this.colIUP});
            this.dgvListInvoice.Location = new System.Drawing.Point(349, 90);
            this.dgvListInvoice.Name = "dgvListInvoice";
            this.dgvListInvoice.ReadOnly = true;
            this.dgvListInvoice.RowHeadersVisible = false;
            this.dgvListInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListInvoice.Size = new System.Drawing.Size(423, 318);
            this.dgvListInvoice.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colIPN
            // 
            this.colIPN.HeaderText = "Tên Sản Phẩm";
            this.colIPN.Name = "colIPN";
            this.colIPN.ReadOnly = true;
            // 
            // colIQ
            // 
            this.colIQ.HeaderText = "Số lượng";
            this.colIQ.Name = "colIQ";
            this.colIQ.ReadOnly = true;
            // 
            // colIUP
            // 
            this.colIUP.HeaderText = "Đơn giá";
            this.colIUP.Name = "colIUP";
            this.colIUP.ReadOnly = true;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(540, 425);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(621, 426);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa SP";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // dgvListProduct
            // 
            this.dgvListProduct.AllowUserToAddRows = false;
            this.dgvListProduct.AllowUserToDeleteRows = false;
            this.dgvListProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPId,
            this.colImage,
            this.colProductName,
            this.colStock,
            this.colPrice});
            this.dgvListProduct.Location = new System.Drawing.Point(13, 53);
            this.dgvListProduct.Name = "dgvListProduct";
            this.dgvListProduct.ReadOnly = true;
            this.dgvListProduct.RowHeadersVisible = false;
            this.dgvListProduct.RowTemplate.Height = 100;
            this.dgvListProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListProduct.Size = new System.Drawing.Size(315, 396);
            this.dgvListProduct.TabIndex = 5;
            this.dgvListProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListProduct_CellDoubleClick);
            this.dgvListProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListProduct_CellFormatting);
            // 
            // colPId
            // 
            this.colPId.DataPropertyName = "MASACH";
            this.colPId.HeaderText = "Id";
            this.colPId.Name = "colPId";
            this.colPId.ReadOnly = true;
            this.colPId.Visible = false;
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "ANH";
            this.colImage.HeaderText = "Hình ảnh";
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "TENSACH";
            this.colProductName.HeaderText = "Tên SP";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.DataPropertyName = "SLTK";
            this.colStock.HeaderText = "SLTK";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "GIATIEN";
            this.colPrice.HeaderText = "Giá tiền";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tổng tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nhân viên";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(421, 56);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(108, 20);
            this.txtCode.TabIndex = 11;
            // 
            // cboStaffName
            // 
            this.cboStaffName.FormattingEnabled = true;
            this.cboStaffName.Location = new System.Drawing.Point(638, 56);
            this.cboStaffName.Name = "cboStaffName";
            this.cboStaffName.Size = new System.Drawing.Size(134, 21);
            this.cboStaffName.TabIndex = 12;
            this.cboStaffName.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(253, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Hoá đơn";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(702, 426);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Xoá hết";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(444, 431);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "0.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "đ";
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Checked = true;
            this.chkCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheck.Location = new System.Drawing.Point(638, 23);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(63, 17);
            this.chkCheck.TabIndex = 18;
            this.chkCheck.Text = "kiểm tra";
            this.chkCheck.UseVisualStyleBackColor = true;
            this.chkCheck.Visible = false;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(638, 56);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(134, 20);
            this.txtStaffName.TabIndex = 19;
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.Location = new System.Drawing.Point(737, 25);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(35, 13);
            this.lblManv.TabIndex = 20;
            this.lblManv.Text = "label6";
            this.lblManv.Visible = false;
            // 
            // frmBH
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblManv);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.chkCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboStaffName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListProduct);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.dgvListInvoice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBH";
            this.Text = "Bán hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBH_FormClosing);
            this.Load += new System.EventHandler(this.frmBH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvListInvoice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridView dgvListProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.ComboBox cboStaffName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIUP;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPId;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblManv;
    }
}