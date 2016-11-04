namespace Quan_ly_kho_hang
{
    partial class frmXuathang
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grbXuathang = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblMachinhanh = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayxuat = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChinhanh = new System.Windows.Forms.ComboBox();
            this.dgvHanghoa = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grbXuathang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grbXuathang);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvHanghoa);
            this.splitContainer1.Size = new System.Drawing.Size(790, 390);
            this.splitContainer1.SplitterDistance = 144;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbXuathang
            // 
            this.grbXuathang.Controls.Add(this.btnHistory);
            this.grbXuathang.Controls.Add(this.btnHuy);
            this.grbXuathang.Controls.Add(this.btnXuat);
            this.grbXuathang.Controls.Add(this.lblDiachi);
            this.grbXuathang.Controls.Add(this.lblSDT);
            this.grbXuathang.Controls.Add(this.lblMachinhanh);
            this.grbXuathang.Controls.Add(this.label4);
            this.grbXuathang.Controls.Add(this.dtpNgayxuat);
            this.grbXuathang.Controls.Add(this.label3);
            this.grbXuathang.Controls.Add(this.label2);
            this.grbXuathang.Controls.Add(this.label1);
            this.grbXuathang.Controls.Add(this.cmbChinhanh);
            this.grbXuathang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbXuathang.Location = new System.Drawing.Point(0, 0);
            this.grbXuathang.Name = "grbXuathang";
            this.grbXuathang.Size = new System.Drawing.Size(790, 144);
            this.grbXuathang.TabIndex = 0;
            this.grbXuathang.TabStop = false;
            this.grbXuathang.Text = "Thông tin xuất hàng";
            this.grbXuathang.Enter += new System.EventHandler(this.grbXuathang_Enter);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(584, 89);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(584, 41);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(75, 23);
            this.btnXuat.TabIndex = 11;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(503, 44);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(47, 13);
            this.lblDiachi.TabIndex = 10;
            this.lblDiachi.Text = "lblDiachi";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(503, 100);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(39, 13);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "lblSDT";
            // 
            // lblMachinhanh
            // 
            this.lblMachinhanh.AutoSize = true;
            this.lblMachinhanh.Location = new System.Drawing.Point(345, 49);
            this.lblMachinhanh.Name = "lblMachinhanh";
            this.lblMachinhanh.Size = new System.Drawing.Size(77, 13);
            this.lblMachinhanh.TabIndex = 8;
            this.lblMachinhanh.Text = "txtMachinhanh";
            this.lblMachinhanh.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày xuất";
            // 
            // dtpNgayxuat
            // 
            this.dtpNgayxuat.Location = new System.Drawing.Point(124, 99);
            this.dtpNgayxuat.Name = "dtpNgayxuat";
            this.dtpNgayxuat.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayxuat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi nhánh";
            // 
            // cmbChinhanh
            // 
            this.cmbChinhanh.FormattingEnabled = true;
            this.cmbChinhanh.Location = new System.Drawing.Point(124, 41);
            this.cmbChinhanh.Name = "cmbChinhanh";
            this.cmbChinhanh.Size = new System.Drawing.Size(200, 21);
            this.cmbChinhanh.TabIndex = 2;
            this.cmbChinhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChinhanh_SelectedIndexChanged);
            // 
            // dgvHanghoa
            // 
            this.dgvHanghoa.AllowUserToAddRows = false;
            this.dgvHanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanghoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHH,
            this.TenHH,
            this.NSX,
            this.ThongTin,
            this.SoLuong,
            this.SoLuongXuat,
            this.GiaXuat,
            this.TongTien});
            this.dgvHanghoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHanghoa.Location = new System.Drawing.Point(0, 0);
            this.dgvHanghoa.Name = "dgvHanghoa";
            this.dgvHanghoa.Size = new System.Drawing.Size(790, 242);
            this.dgvHanghoa.TabIndex = 0;
            this.dgvHanghoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanghoa_CellClick);
            this.dgvHanghoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanghoa_CellContentClick);
            this.dgvHanghoa.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanghoa_CellValueChanged);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // MaHH
            // 
            this.MaHH.DataPropertyName = "MaHH";
            this.MaHH.HeaderText = "MaHH";
            this.MaHH.Name = "MaHH";
            this.MaHH.ReadOnly = true;
            this.MaHH.Visible = false;
            // 
            // TenHH
            // 
            this.TenHH.DataPropertyName = "TenHH";
            this.TenHH.HeaderText = "Tên hàng hóa";
            this.TenHH.Name = "TenHH";
            this.TenHH.ReadOnly = true;
            // 
            // NSX
            // 
            this.NSX.DataPropertyName = "NSX";
            this.NSX.HeaderText = "NSX";
            this.NSX.Name = "NSX";
            this.NSX.ReadOnly = true;
            this.NSX.Width = 50;
            // 
            // ThongTin
            // 
            this.ThongTin.DataPropertyName = "ThongTin";
            this.ThongTin.HeaderText = "Thông tin";
            this.ThongTin.Name = "ThongTin";
            this.ThongTin.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 85;
            // 
            // SoLuongXuat
            // 
            this.SoLuongXuat.HeaderText = "Số lượng xuất";
            this.SoLuongXuat.Name = "SoLuongXuat";
            // 
            // GiaXuat
            // 
            this.GiaXuat.DataPropertyName = "GiaXuat";
            this.GiaXuat.HeaderText = "Đơn giá";
            this.GiaXuat.Name = "GiaXuat";
            this.GiaXuat.ReadOnly = true;
            this.GiaXuat.Width = 70;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(688, 40);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 13;
            this.btnHistory.Text = "Lịch sử";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // frmXuathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 390);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmXuathang";
            this.Text = "Xuất hàng";
            this.Load += new System.EventHandler(this.frmXuathang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grbXuathang.ResumeLayout(false);
            this.grbXuathang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanghoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grbXuathang;
        private System.Windows.Forms.DataGridView dgvHanghoa;
        private System.Windows.Forms.Label lblMachinhanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayxuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChinhanh;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.Button btnHistory;
    }
}