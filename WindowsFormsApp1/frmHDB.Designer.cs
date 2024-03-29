﻿namespace WindowsFormsApp1
{
    partial class frmHDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHDB));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("abc", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvReceipt = new System.Windows.Forms.DataGridView();
            this.colR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colR_StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colR_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colR_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colR_Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvReceiptDetail = new System.Windows.Forms.DataGridView();
            this.colRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRD_BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRD_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRD_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radReceiptDetail = new System.Windows.Forms.RadioButton();
            this.radReceipt = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblhoadon = new System.Windows.Forms.Label();
            this.txtRD_ID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbldongia = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblsl = new System.Windows.Forms.Label();
            this.lblmasach = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(107, 68);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 40);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Làm\r\n mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(20, 20);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(167, 40);
            this.btnDel.TabIndex = 28;
            this.btnDel.Text = "Xoá";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(19, 68);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 40);
            this.btnEdit.TabIndex = 27;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(19, 20);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // dgvReceipt
            // 
            this.dgvReceipt.AllowUserToAddRows = false;
            this.dgvReceipt.AllowUserToDeleteRows = false;
            this.dgvReceipt.AllowUserToResizeRows = false;
            this.dgvReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colR_ID,
            this.colR_StaffID,
            this.colR_Time,
            this.colR_Total,
            this.colR_Check});
            this.dgvReceipt.Location = new System.Drawing.Point(12, 222);
            this.dgvReceipt.Name = "dgvReceipt";
            this.dgvReceipt.ReadOnly = true;
            this.dgvReceipt.RowHeadersVisible = false;
            this.dgvReceipt.RowHeadersWidth = 51;
            this.dgvReceipt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceipt.Size = new System.Drawing.Size(543, 227);
            this.dgvReceipt.TabIndex = 30;
            this.dgvReceipt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellClick);
            this.dgvReceipt.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceipt_CellDoubleClick);
            // 
            // colR_ID
            // 
            this.colR_ID.DataPropertyName = "MAHD";
            this.colR_ID.HeaderText = "Mã Hoá Đơn";
            this.colR_ID.Name = "colR_ID";
            this.colR_ID.ReadOnly = true;
            // 
            // colR_StaffID
            // 
            this.colR_StaffID.DataPropertyName = "MANV";
            this.colR_StaffID.HeaderText = "Mã Nhân Viên";
            this.colR_StaffID.Name = "colR_StaffID";
            this.colR_StaffID.ReadOnly = true;
            // 
            // colR_Time
            // 
            this.colR_Time.DataPropertyName = "THOIGIAN";
            this.colR_Time.HeaderText = "Thời Gian";
            this.colR_Time.Name = "colR_Time";
            this.colR_Time.ReadOnly = true;
            // 
            // colR_Total
            // 
            this.colR_Total.DataPropertyName = "TONGTIEN";
            this.colR_Total.HeaderText = "Tổng Tiền";
            this.colR_Total.Name = "colR_Total";
            this.colR_Total.ReadOnly = true;
            // 
            // colR_Check
            // 
            this.colR_Check.DataPropertyName = "TRANGTHAI";
            this.colR_Check.HeaderText = "Trạng Thái";
            this.colR_Check.Name = "colR_Check";
            this.colR_Check.ReadOnly = true;
            // 
            // dgvReceiptDetail
            // 
            this.dgvReceiptDetail.AllowUserToAddRows = false;
            this.dgvReceiptDetail.AllowUserToDeleteRows = false;
            this.dgvReceiptDetail.AllowUserToResizeRows = false;
            this.dgvReceiptDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiptDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRID,
            this.colRD_ID,
            this.colBookName,
            this.colRD_BookID,
            this.colRD_Qty,
            this.colRD_Price});
            this.dgvReceiptDetail.Location = new System.Drawing.Point(561, 222);
            this.dgvReceiptDetail.Name = "dgvReceiptDetail";
            this.dgvReceiptDetail.ReadOnly = true;
            this.dgvReceiptDetail.RowHeadersVisible = false;
            this.dgvReceiptDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptDetail.Size = new System.Drawing.Size(637, 227);
            this.dgvReceiptDetail.TabIndex = 33;
            this.dgvReceiptDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceiptDetail_CellDoubleClick);
            // 
            // colRID
            // 
            this.colRID.DataPropertyName = "ID";
            this.colRID.HeaderText = "Id";
            this.colRID.Name = "colRID";
            this.colRID.ReadOnly = true;
            this.colRID.Visible = false;
            // 
            // colRD_ID
            // 
            this.colRD_ID.DataPropertyName = "MAHD";
            this.colRD_ID.HeaderText = "Mã Hoá Đơn";
            this.colRD_ID.Name = "colRD_ID";
            this.colRD_ID.ReadOnly = true;
            // 
            // colBookName
            // 
            this.colBookName.DataPropertyName = "TENSACH";
            this.colBookName.HeaderText = "Tên sách";
            this.colBookName.Name = "colBookName";
            this.colBookName.ReadOnly = true;
            // 
            // colRD_BookID
            // 
            this.colRD_BookID.DataPropertyName = "MASACH";
            this.colRD_BookID.HeaderText = "Mã Sách";
            this.colRD_BookID.Name = "colRD_BookID";
            this.colRD_BookID.ReadOnly = true;
            this.colRD_BookID.Visible = false;
            // 
            // colRD_Qty
            // 
            this.colRD_Qty.DataPropertyName = "SL";
            this.colRD_Qty.HeaderText = "Số Lượng";
            this.colRD_Qty.Name = "colRD_Qty";
            this.colRD_Qty.ReadOnly = true;
            // 
            // colRD_Price
            // 
            this.colRD_Price.DataPropertyName = "GIATIEN";
            this.colRD_Price.HeaderText = "Đơn Giá";
            this.colRD_Price.Name = "colRD_Price";
            this.colRD_Price.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.radReceiptDetail);
            this.groupBox1.Controls.Add(this.radReceipt);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Location = new System.Drawing.Point(561, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 175);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 39);
            this.label9.TabIndex = 32;
            this.label9.Text = "Lưu ý: chọn 1 trong 2 nút trên \r\nđể thêm/xoá/sửa/tìm kiếm/huỷ bỏ\r\ntheo bảng tương" +
    " ứng";
            // 
            // radReceiptDetail
            // 
            this.radReceiptDetail.AutoSize = true;
            this.radReceiptDetail.Location = new System.Drawing.Point(111, 113);
            this.radReceiptDetail.Name = "radReceiptDetail";
            this.radReceiptDetail.Size = new System.Drawing.Size(100, 17);
            this.radReceiptDetail.TabIndex = 31;
            this.radReceiptDetail.Text = "Chi tiết hoá đơn";
            this.radReceiptDetail.UseVisualStyleBackColor = true;
            // 
            // radReceipt
            // 
            this.radReceipt.AutoSize = true;
            this.radReceipt.Checked = true;
            this.radReceipt.Location = new System.Drawing.Point(20, 113);
            this.radReceipt.Name = "radReceipt";
            this.radReceipt.Size = new System.Drawing.Size(66, 17);
            this.radReceipt.TabIndex = 30;
            this.radReceipt.TabStop = true;
            this.radReceipt.Text = "Hoá dơn";
            this.radReceipt.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.chkCheck);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.dtpDate);
            this.groupBox2.Controls.Add(this.txtStaffID);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 175);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hoá đơn bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Trạng thái:";
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Checked = true;
            this.chkCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheck.Location = new System.Drawing.Point(98, 146);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(59, 17);
            this.chkCheck.TabIndex = 48;
            this.chkCheck.Text = "Tồn tại";
            this.chkCheck.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(94, 117);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 20);
            this.txtTotal.TabIndex = 47;
            this.txtTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_KeyPress);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(92, 85);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 20);
            this.dtpDate.TabIndex = 46;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(94, 51);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(178, 20);
            this.txtStaffID.TabIndex = 43;
            this.txtStaffID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffID_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(178, 20);
            this.txtID.TabIndex = 42;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Thành tiền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Mã hoá đơn:";
            // 
            // lblhoadon
            // 
            this.lblhoadon.AutoSize = true;
            this.lblhoadon.Location = new System.Drawing.Point(6, 22);
            this.lblhoadon.Name = "lblhoadon";
            this.lblhoadon.Size = new System.Drawing.Size(68, 13);
            this.lblhoadon.TabIndex = 53;
            this.lblhoadon.Text = "Mã hoá đơn:";
            // 
            // txtRD_ID
            // 
            this.txtRD_ID.Location = new System.Drawing.Point(77, 18);
            this.txtRD_ID.Name = "txtRD_ID";
            this.txtRD_ID.Size = new System.Drawing.Size(151, 20);
            this.txtRD_ID.TabIndex = 52;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(77, 115);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 20);
            this.txtPrice.TabIndex = 51;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Location = new System.Drawing.Point(6, 120);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(47, 13);
            this.lbldongia.TabIndex = 50;
            this.lbldongia.Text = "Đơn giá:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(77, 84);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(151, 20);
            this.txtQuantity.TabIndex = 45;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(77, 51);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(151, 20);
            this.txtBookID.TabIndex = 44;
            this.txtBookID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBookID_KeyPress);
            // 
            // lblsl
            // 
            this.lblsl.AutoSize = true;
            this.lblsl.Location = new System.Drawing.Point(6, 87);
            this.lblsl.Name = "lblsl";
            this.lblsl.Size = new System.Drawing.Size(52, 13);
            this.lblsl.TabIndex = 40;
            this.lblsl.Text = "Số lượng:";
            // 
            // lblmasach
            // 
            this.lblmasach.AutoSize = true;
            this.lblmasach.Location = new System.Drawing.Point(6, 56);
            this.lblmasach.Name = "lblmasach";
            this.lblmasach.Size = new System.Drawing.Size(51, 13);
            this.lblmasach.TabIndex = 39;
            this.lblmasach.Text = "Mã sách:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblhoadon);
            this.groupBox3.Controls.Add(this.txtRD_ID);
            this.groupBox3.Controls.Add(this.txtBookID);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.txtQuantity);
            this.groupBox3.Controls.Add(this.lblmasach);
            this.groupBox3.Controls.Add(this.lbldongia);
            this.groupBox3.Controls.Add(this.lblsl);
            this.groupBox3.Location = new System.Drawing.Point(309, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 175);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết hoá đơn bán";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Location = new System.Drawing.Point(110, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 32);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(452, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 20);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(101, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(340, 20);
            this.txtSearch.TabIndex = 57;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // listView1
            // 
            listViewGroup1.Header = "abc";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(124, 523);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(309, 125);
            this.listView1.TabIndex = 56;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmHDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 721);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReceiptDetail);
            this.Controls.Add(this.dgvReceipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHDB";
            this.Text = "Hoá đơn bán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHDB_FormClosing);
            this.Load += new System.EventHandler(this.frmHDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvReceipt;
        private System.Windows.Forms.DataGridView dgvReceiptDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colR_StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colR_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn colR_Total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colR_Check;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkCheck;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblsl;
        private System.Windows.Forms.Label lblmasach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radReceipt;
        private System.Windows.Forms.RadioButton radReceiptDetail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblhoadon;
        private System.Windows.Forms.TextBox txtRD_ID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRD_BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRD_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRD_Price;
        private System.Windows.Forms.ListView listView1;
    }
}