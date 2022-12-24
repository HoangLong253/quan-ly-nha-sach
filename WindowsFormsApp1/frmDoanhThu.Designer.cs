namespace WindowsFormsApp1
{
    partial class frmDoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStatistics = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvTotal = new System.Windows.Forms.DataGridView();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu";
            // 
            // dgvStatistics
            // 
            this.dgvStatistics.AllowUserToAddRows = false;
            this.dgvStatistics.AllowUserToDeleteRows = false;
            this.dgvStatistics.AllowUserToResizeRows = false;
            this.dgvStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colStat});
            this.dgvStatistics.Location = new System.Drawing.Point(12, 175);
            this.dgvStatistics.Name = "dgvStatistics";
            this.dgvStatistics.ReadOnly = true;
            this.dgvStatistics.RowHeadersVisible = false;
            this.dgvStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatistics.Size = new System.Drawing.Size(651, 274);
            this.dgvStatistics.TabIndex = 8;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "THOIGIAN";
            this.colDate.HeaderText = "Thời gian";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colStat
            // 
            this.colStat.DataPropertyName = "DOANHTHU";
            this.colStat.HeaderText = "Doanh Thu";
            this.colStat.Name = "colStat";
            this.colStat.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMonth);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 50);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(680, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 20);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Huỷ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(609, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 20);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(488, 17);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(106, 20);
            this.txtYear.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Năm:";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(303, 17);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(123, 20);
            this.txtMonth.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tháng:";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(111, 17);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(118, 20);
            this.txtDay.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Theo:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(118, 16);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(101, 20);
            this.dtpDate.TabIndex = 8;
            this.dtpDate.Visible = false;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // dgvTotal
            // 
            this.dgvTotal.AllowUserToAddRows = false;
            this.dgvTotal.AllowUserToDeleteRows = false;
            this.dgvTotal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTotal});
            this.dgvTotal.Location = new System.Drawing.Point(669, 175);
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            this.dgvTotal.RowHeadersVisible = false;
            this.dgvTotal.Size = new System.Drawing.Size(110, 55);
            this.dgvTotal.TabIndex = 10;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "TONGDOANHTHU";
            this.colTotal.HeaderText = "Tổng doanh thu";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // frmDoanhThu
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStatistics);
            this.Controls.Add(this.label1);
            this.Name = "frmDoanhThu";
            this.Text = "Doanh thu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoanhThu_FormClosing);
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistics)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStatistics;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStat;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
    }
}