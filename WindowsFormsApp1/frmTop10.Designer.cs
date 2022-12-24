namespace WindowsFormsApp1
{
    partial class frmTop10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTop10));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTop10 = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colBookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPublishing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuying = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top 10 SP bán chạy nhất";
            // 
            // dgvTop10
            // 
            this.dgvTop10.AllowUserToAddRows = false;
            this.dgvTop10.AllowUserToDeleteRows = false;
            this.dgvTop10.AllowUserToResizeRows = false;
            this.dgvTop10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colImage,
            this.colBookName,
            this.colAuthor,
            this.colPublishing,
            this.colBuying});
            this.dgvTop10.Location = new System.Drawing.Point(12, 137);
            this.dgvTop10.Name = "dgvTop10";
            this.dgvTop10.ReadOnly = true;
            this.dgvTop10.RowHeadersVisible = false;
            this.dgvTop10.RowTemplate.Height = 100;
            this.dgvTop10.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTop10.Size = new System.Drawing.Size(760, 312);
            this.dgvTop10.TabIndex = 1;
            this.dgvTop10.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTop10_CellFormatting);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "MASACH";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colImage
            // 
            this.colImage.DataPropertyName = "ANH";
            this.colImage.HeaderText = "Hình ảnh";
            this.colImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colImage.Name = "colImage";
            this.colImage.ReadOnly = true;
            // 
            // colBookName
            // 
            this.colBookName.DataPropertyName = "TENSACH";
            this.colBookName.HeaderText = "Tên sách / truyện";
            this.colBookName.Name = "colBookName";
            this.colBookName.ReadOnly = true;
            // 
            // colAuthor
            // 
            this.colAuthor.DataPropertyName = "TENTACGIA";
            this.colAuthor.HeaderText = "Tác giả";
            this.colAuthor.Name = "colAuthor";
            this.colAuthor.ReadOnly = true;
            // 
            // colPublishing
            // 
            this.colPublishing.DataPropertyName = "NHAXUATBAN";
            this.colPublishing.HeaderText = "Nhà xuất bản";
            this.colPublishing.Name = "colPublishing";
            this.colPublishing.ReadOnly = true;
            // 
            // colBuying
            // 
            this.colBuying.DataPropertyName = "TONGLUOTMUA";
            this.colBuying.HeaderText = "Tổng số lượng sản phẩm được bán";
            this.colBuying.Name = "colBuying";
            this.colBuying.ReadOnly = true;
            // 
            // frmTop10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvTop10);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTop10";
            this.Text = "Top 10 sản phẩm bán chạy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTop10_FormClosing);
            this.Load += new System.EventHandler(this.frmTop10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTop10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPublishing;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuying;
    }
}