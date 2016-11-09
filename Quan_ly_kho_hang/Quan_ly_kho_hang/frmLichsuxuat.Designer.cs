namespace Quan_ly_kho_hang
{
    partial class frmLichsuxuat
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
            this.lblChinhanh = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblMachinhanh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHanghoa = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThongTin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.splitContainer1.Size = new System.Drawing.Size(801, 374);
            this.splitContainer1.SplitterDistance = 97;
            this.splitContainer1.TabIndex = 0;
            // 
            // grbXuathang
            // 
            this.grbXuathang.Controls.Add(this.lblChinhanh);
            this.grbXuathang.Controls.Add(this.lblDiachi);
            this.grbXuathang.Controls.Add(this.lblSDT);
            this.grbXuathang.Controls.Add(this.lblMachinhanh);
            this.grbXuathang.Controls.Add(this.label3);
            this.grbXuathang.Controls.Add(this.label2);
            this.grbXuathang.Controls.Add(this.label1);
            this.grbXuathang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbXuathang.Location = new System.Drawing.Point(0, 0);
            this.grbXuathang.Name = "grbXuathang";
            this.grbXuathang.Size = new System.Drawing.Size(801, 97);
            this.grbXuathang.TabIndex = 1;
            this.grbXuathang.TabStop = false;
            this.grbXuathang.Text = "Thông tin xuất hàng";
            // 
            // lblChinhanh
            // 
            this.lblChinhanh.AutoSize = true;
            this.lblChinhanh.Location = new System.Drawing.Point(96, 31);
            this.lblChinhanh.Name = "lblChinhanh";
            this.lblChinhanh.Size = new System.Drawing.Size(62, 13);
            this.lblChinhanh.TabIndex = 11;
            this.lblChinhanh.Text = "lblChinhanh";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(93, 65);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(47, 13);
            this.lblDiachi.TabIndex = 10;
            this.lblDiachi.Text = "lblDiachi";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(383, 66);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(39, 13);
            this.lblSDT.TabIndex = 9;
            this.lblSDT.Text = "lblSDT";
            // 
            // lblMachinhanh
            // 
            this.lblMachinhanh.AutoSize = true;
            this.lblMachinhanh.Location = new System.Drawing.Point(345, 31);
            this.lblMachinhanh.Name = "lblMachinhanh";
            this.lblMachinhanh.Size = new System.Drawing.Size(77, 13);
            this.lblMachinhanh.TabIndex = 8;
            this.lblMachinhanh.Text = "txtMachinhanh";
            this.lblMachinhanh.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "SDT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chi nhánh";
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
            this.GiaXuat,
            this.NgayXuat,
            this.TongTien});
            this.dgvHanghoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHanghoa.Location = new System.Drawing.Point(0, 0);
            this.dgvHanghoa.Name = "dgvHanghoa";
            this.dgvHanghoa.Size = new System.Drawing.Size(801, 273);
            this.dgvHanghoa.TabIndex = 1;
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
            this.SoLuong.HeaderText = "Số lượng xuất";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 150;
            // 
            // GiaXuat
            // 
            this.GiaXuat.DataPropertyName = "GiaXuat";
            this.GiaXuat.HeaderText = "Đơn giá";
            this.GiaXuat.Name = "GiaXuat";
            this.GiaXuat.ReadOnly = true;
            this.GiaXuat.Width = 70;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.HeaderText = "Ngày xuất";
            this.NgayXuat.Name = "NgayXuat";
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // frmLichsuxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 374);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmLichsuxuat";
            this.Text = "Lịch sử xuất hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLichsuxuat_FormClosing);
            this.Load += new System.EventHandler(this.frmLichsuxuat_Load);
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
        private System.Windows.Forms.DataGridView dgvHanghoa;
        private System.Windows.Forms.GroupBox grbXuathang;
        private System.Windows.Forms.Label lblChinhanh;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblMachinhanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
    }
}