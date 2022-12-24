namespace WindowsFormsApp1
{
    partial class frmQLSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSP));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.colBookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtPublishing = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboBookType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvReceiptDetail = new System.Windows.Forms.DataGridView();
            this.dgvReceiptDetail1 = new System.Windows.Forms.DataGridView();
            this.colS_RID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colS_RD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colS_RD_BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colS_RD_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colS_RD_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colI_RID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colI_RD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colI_RD_BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colI_RD_Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colI_RD_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetail1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(28, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 40);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(112, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 40);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(28, 82);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(80, 40);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Xoá";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(112, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 40);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Làm\r\nmới \r\n";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBookType,
            this.colBookID,
            this.colImage,
            this.colBookName,
            this.colAuthor,
            this.colType,
            this.colPublishing,
            this.colPrice,
            this.colQuantity});
            this.dgvProduct.Location = new System.Drawing.Point(12, 208);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 100;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(760, 241);
            this.dgvProduct.TabIndex = 18;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            this.dgvProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProduct_CellFormatting);
            // 
            // colBookType
            // 
            this.colBookType.DataPropertyName = "MALOAISACH";
            this.colBookType.HeaderText = "Mã loại sách";
            this.colBookType.MinimumWidth = 6;
            this.colBookType.Name = "colBookType";
            this.colBookType.ReadOnly = true;
            this.colBookType.Visible = false;
            // 
            // colBookID
            // 
            this.colBookID.DataPropertyName = "MASACH";
            this.colBookID.HeaderText = "Mã sách";
            this.colBookID.MinimumWidth = 6;
            this.colBookID.Name = "colBookID";
            this.colBookID.ReadOnly = true;
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "ANH";
            this.colImage.HeaderText = "Ảnh";
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImage.MinimumWidth = 6;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            // 
            // colBookName
            // 
            this.colBookName.DataPropertyName = "TENSACH";
            this.colBookName.HeaderText = "Tên sách";
            this.colBookName.MinimumWidth = 6;
            this.colBookName.Name = "colBookName";
            this.colBookName.ReadOnly = true;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "TENTACGIA";
            this.colAuthor.HeaderText = "Tên tác giả";
            this.colAuthor.MinimumWidth = 6;
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "THELOAI";
            this.colType.HeaderText = "Thể loại";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            // 
            // colPublishing
            // 
            this.colPublishing.DataPropertyName = "NHAXUATBAN";
            this.colPublishing.HeaderText = "Nhà xuất bản";
            this.colPublishing.MinimumWidth = 6;
            this.colPublishing.Name = "colPublishing";
            this.colPublishing.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "GIATIEN";
            this.colPrice.HeaderText = "Giá tiền";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "SLTK";
            this.colQuantity.HeaderText = "SLTK";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            this.ofdImage.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên sách:";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(80, 21);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(137, 20);
            this.txtBookID.TabIndex = 3;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(80, 93);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(137, 20);
            this.txtBookName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên tác giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá tiền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "SLTK:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(80, 124);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(137, 20);
            this.txtAuthor.TabIndex = 10;
            // 
            // txtPublishing
            // 
            this.txtPublishing.Location = new System.Drawing.Point(297, 24);
            this.txtPublishing.Name = "txtPublishing";
            this.txtPublishing.Size = new System.Drawing.Size(120, 20);
            this.txtPublishing.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(297, 55);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(58, 20);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(297, 92);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 20);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // cboBookType
            // 
            this.cboBookType.FormattingEnabled = true;
            this.cboBookType.Location = new System.Drawing.Point(80, 55);
            this.cboBookType.Name = "cboBookType";
            this.cboBookType.Size = new System.Drawing.Size(138, 21);
            this.cboBookType.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cboBookType);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtPublishing);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.txtBookID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(426, 154);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 57;
            this.label9.Text = ".000 đ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picAnh);
            this.groupBox2.Location = new System.Drawing.Point(436, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(119, 153);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình ảnh";
            // 
            // picAnh
            // 
            this.picAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh.Location = new System.Drawing.Point(9, 17);
            this.picAnh.Margin = new System.Windows.Forms.Padding(2);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(100, 127);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh.TabIndex = 21;
            this.picAnh.TabStop = false;
            this.picAnh.Click += new System.EventHandler(this.ptbAnh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnDel);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Location = new System.Drawing.Point(561, 6);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(211, 153);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Location = new System.Drawing.Point(132, 165);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(537, 37);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(452, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 20);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Tìm kiếm:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(101, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(340, 20);
            this.txtSearch.TabIndex = 57;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvReceiptDetail
            // 
            this.dgvReceiptDetail.AllowUserToAddRows = false;
            this.dgvReceiptDetail.AllowUserToDeleteRows = false;
            this.dgvReceiptDetail.AllowUserToResizeRows = false;
            this.dgvReceiptDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiptDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colS_RID,
            this.colS_RD_ID,
            this.colS_RD_BookID,
            this.colS_RD_Qty,
            this.colS_RD_Price});
            this.dgvReceiptDetail.Location = new System.Drawing.Point(403, 222);
            this.dgvReceiptDetail.Name = "dgvReceiptDetail";
            this.dgvReceiptDetail.ReadOnly = true;
            this.dgvReceiptDetail.RowHeadersVisible = false;
            this.dgvReceiptDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptDetail.Size = new System.Drawing.Size(369, 227);
            this.dgvReceiptDetail.TabIndex = 57;
            this.dgvReceiptDetail.Visible = false;
            // 
            // dgvReceiptDetail1
            // 
            this.dgvReceiptDetail1.AllowUserToAddRows = false;
            this.dgvReceiptDetail1.AllowUserToDeleteRows = false;
            this.dgvReceiptDetail1.AllowUserToResizeRows = false;
            this.dgvReceiptDetail1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceiptDetail1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptDetail1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colI_RID,
            this.colI_RD_ID,
            this.colI_RD_BookID,
            this.colI_RD_Qty,
            this.colI_RD_Price});
            this.dgvReceiptDetail1.Location = new System.Drawing.Point(12, 222);
            this.dgvReceiptDetail1.Name = "dgvReceiptDetail1";
            this.dgvReceiptDetail1.ReadOnly = true;
            this.dgvReceiptDetail1.RowHeadersVisible = false;
            this.dgvReceiptDetail1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptDetail1.Size = new System.Drawing.Size(365, 227);
            this.dgvReceiptDetail1.TabIndex = 58;
            this.dgvReceiptDetail1.Visible = false;
            // 
            // colS_RID
            // 
            this.colS_RID.DataPropertyName = "ID";
            this.colS_RID.HeaderText = "Id";
            this.colS_RID.Name = "colS_RID";
            this.colS_RID.ReadOnly = true;
            this.colS_RID.Visible = false;
            // 
            // colS_RD_ID
            // 
            this.colS_RD_ID.DataPropertyName = "MAHD";
            this.colS_RD_ID.HeaderText = "Mã Hoá Đơn";
            this.colS_RD_ID.Name = "colS_RD_ID";
            this.colS_RD_ID.ReadOnly = true;
            // 
            // colS_RD_BookID
            // 
            this.colS_RD_BookID.DataPropertyName = "MASACH";
            this.colS_RD_BookID.HeaderText = "Mã Sách";
            this.colS_RD_BookID.Name = "colS_RD_BookID";
            this.colS_RD_BookID.ReadOnly = true;
            // 
            // colS_RD_Qty
            // 
            this.colS_RD_Qty.DataPropertyName = "SL";
            this.colS_RD_Qty.HeaderText = "Số Lượng";
            this.colS_RD_Qty.Name = "colS_RD_Qty";
            this.colS_RD_Qty.ReadOnly = true;
            // 
            // colS_RD_Price
            // 
            this.colS_RD_Price.DataPropertyName = "GIATIEN";
            this.colS_RD_Price.HeaderText = "Đơn Giá";
            this.colS_RD_Price.Name = "colS_RD_Price";
            this.colS_RD_Price.ReadOnly = true;
            // 
            // colI_RID
            // 
            this.colI_RID.DataPropertyName = "ID";
            this.colI_RID.HeaderText = "Id";
            this.colI_RID.Name = "colI_RID";
            this.colI_RID.ReadOnly = true;
            this.colI_RID.Visible = false;
            // 
            // colI_RD_ID
            // 
            this.colI_RD_ID.DataPropertyName = "MAHD";
            this.colI_RD_ID.HeaderText = "Mã Hoá Đơn";
            this.colI_RD_ID.Name = "colI_RD_ID";
            this.colI_RD_ID.ReadOnly = true;
            // 
            // colI_RD_BookID
            // 
            this.colI_RD_BookID.DataPropertyName = "MASACH";
            this.colI_RD_BookID.HeaderText = "Mã Sách";
            this.colI_RD_BookID.Name = "colI_RD_BookID";
            this.colI_RD_BookID.ReadOnly = true;
            // 
            // colI_RD_Qty
            // 
            this.colI_RD_Qty.DataPropertyName = "SL";
            this.colI_RD_Qty.HeaderText = "Số Lượng";
            this.colI_RD_Qty.Name = "colI_RD_Qty";
            this.colI_RD_Qty.ReadOnly = true;
            // 
            // colI_RD_Price
            // 
            this.colI_RD_Price.DataPropertyName = "GIATIEN";
            this.colI_RD_Price.HeaderText = "Đơn Giá";
            this.colI_RD_Price.Name = "colI_RD_Price";
            this.colI_RD_Price.ReadOnly = true;
            // 
            // frmQLSP
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvReceiptDetail1);
            this.Controls.Add(this.dgvReceiptDetail);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQLSP";
            this.Text = "Quản lý sản phẩm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLSP_FormClosing);
            this.Load += new System.EventHandler(this.frmQLSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetail1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtPublishing;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cboBookType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookID;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvReceiptDetail;
        private System.Windows.Forms.DataGridView dgvReceiptDetail1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS_RID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS_RD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS_RD_BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS_RD_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colS_RD_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn colI_RID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colI_RD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colI_RD_BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colI_RD_Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colI_RD_Price;
    }
}

