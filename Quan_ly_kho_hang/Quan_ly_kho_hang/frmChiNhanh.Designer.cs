namespace Quan_ly_kho_hang
{
    partial class frmChiNhanh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbThongTinChiNhanh = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenCN = new System.Windows.Forms.TextBox();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTenCN = new System.Windows.Forms.Label();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblTim = new System.Windows.Forms.ToolStripLabel();
            this.txtTimMaCN = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimTenCN = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimSDT = new System.Windows.Forms.ToolStripTextBox();
            this.txtTimDiaChi = new System.Windows.Forms.ToolStripTextBox();
            this.dgvThongTinChiNhanh = new System.Windows.Forms.DataGridView();
            this.colMaCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenCN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grbThongTinChiNhanh.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiNhanh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbThongTinChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 131);
            this.panel1.TabIndex = 0;
            // 
            // grbThongTinChiNhanh
            // 
            this.grbThongTinChiNhanh.Controls.Add(this.txtDiaChi);
            this.grbThongTinChiNhanh.Controls.Add(this.txtSDT);
            this.grbThongTinChiNhanh.Controls.Add(this.txtTenCN);
            this.grbThongTinChiNhanh.Controls.Add(this.txtMaCN);
            this.grbThongTinChiNhanh.Controls.Add(this.lblSDT);
            this.grbThongTinChiNhanh.Controls.Add(this.lblDiaChi);
            this.grbThongTinChiNhanh.Controls.Add(this.lblTenCN);
            this.grbThongTinChiNhanh.Controls.Add(this.lblMaCN);
            this.grbThongTinChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbThongTinChiNhanh.Location = new System.Drawing.Point(0, 0);
            this.grbThongTinChiNhanh.Name = "grbThongTinChiNhanh";
            this.grbThongTinChiNhanh.Size = new System.Drawing.Size(681, 131);
            this.grbThongTinChiNhanh.TabIndex = 0;
            this.grbThongTinChiNhanh.TabStop = false;
            this.grbThongTinChiNhanh.Text = "Thông tin chi nhánh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(143, 98);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(255, 20);
            this.txtDiaChi.TabIndex = 7;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            this.txtDiaChi.Enter += new System.EventHandler(this.txtDiaChi_Enter);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(143, 72);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(149, 20);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.Enter += new System.EventHandler(this.txtSDT_Enter);
            // 
            // txtTenCN
            // 
            this.txtTenCN.Location = new System.Drawing.Point(143, 46);
            this.txtTenCN.Name = "txtTenCN";
            this.txtTenCN.Size = new System.Drawing.Size(255, 20);
            this.txtTenCN.TabIndex = 5;
            this.txtTenCN.TextChanged += new System.EventHandler(this.txtTenCN_TextChanged);
            this.txtTenCN.Enter += new System.EventHandler(this.txtTenCN_Enter);
            // 
            // txtMaCN
            // 
            this.txtMaCN.Location = new System.Drawing.Point(143, 20);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(100, 20);
            this.txtMaCN.TabIndex = 4;
            this.txtMaCN.TextChanged += new System.EventHandler(this.txtMaCN_TextChanged);
            this.txtMaCN.Enter += new System.EventHandler(this.txtMaCN_Enter);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(12, 70);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(108, 21);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(12, 96);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(65, 21);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblTenCN
            // 
            this.lblTenCN.AutoSize = true;
            this.lblTenCN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenCN.Location = new System.Drawing.Point(12, 44);
            this.lblTenCN.Name = "lblTenCN";
            this.lblTenCN.Size = new System.Drawing.Size(115, 21);
            this.lblTenCN.TabIndex = 1;
            this.lblTenCN.Text = "Tên chi nhánh";
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaCN.Location = new System.Drawing.Point(12, 18);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(110, 21);
            this.lblMaCN.TabIndex = 0;
            this.lblMaCN.Text = "Mã chi nhánh";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnThoat);
            this.grbChucNang.Controls.Add(this.btnLuu);
            this.grbChucNang.Controls.Add(this.btnLamMoi);
            this.grbChucNang.Controls.Add(this.btnXoa);
            this.grbChucNang.Controls.Add(this.btnSua);
            this.grbChucNang.Controls.Add(this.btnThem);
            this.grbChucNang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbChucNang.Location = new System.Drawing.Point(0, 131);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(681, 91);
            this.grbChucNang.TabIndex = 1;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(417, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 60);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(336, 19);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 60);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(255, 19);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 60);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(174, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 60);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(93, 19);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 60);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(12, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 60);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTim,
            this.txtTimMaCN,
            this.txtTimTenCN,
            this.txtTimSDT,
            this.txtTimDiaChi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 222);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(681, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblTim
            // 
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(28, 22);
            this.lblTim.Text = "Tìm";
            // 
            // txtTimMaCN
            // 
            this.txtTimMaCN.Name = "txtTimMaCN";
            this.txtTimMaCN.Size = new System.Drawing.Size(103, 25);
            this.txtTimMaCN.Text = "-- Mã CN";
            this.txtTimMaCN.Click += new System.EventHandler(this.txtTimMaCN_Click);
            this.txtTimMaCN.TextChanged += new System.EventHandler(this.txtTimMaCN_TextChanged);
            // 
            // txtTimTenCN
            // 
            this.txtTimTenCN.Name = "txtTimTenCN";
            this.txtTimTenCN.Size = new System.Drawing.Size(200, 25);
            this.txtTimTenCN.Text = "-- Tên CN";
            this.txtTimTenCN.Click += new System.EventHandler(this.txtTimTenCN_Click);
            this.txtTimTenCN.TextChanged += new System.EventHandler(this.txtTimTenCN_TextChanged);
            // 
            // txtTimSDT
            // 
            this.txtTimSDT.Name = "txtTimSDT";
            this.txtTimSDT.Size = new System.Drawing.Size(100, 25);
            this.txtTimSDT.Text = "-- SĐT";
            this.txtTimSDT.Click += new System.EventHandler(this.txtTimSDT_Click);
            this.txtTimSDT.TextChanged += new System.EventHandler(this.txtTimSDT_TextChanged);
            // 
            // txtTimDiaChi
            // 
            this.txtTimDiaChi.Name = "txtTimDiaChi";
            this.txtTimDiaChi.Size = new System.Drawing.Size(160, 25);
            this.txtTimDiaChi.Text = "-- Địa chỉ";
            this.txtTimDiaChi.Click += new System.EventHandler(this.txtTimDiaChi_Click);
            this.txtTimDiaChi.TextChanged += new System.EventHandler(this.txtTimDiaChi_TextChanged);
            // 
            // dgvThongTinChiNhanh
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinChiNhanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvThongTinChiNhanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChiNhanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaCN,
            this.colTenCN,
            this.colSDT,
            this.colDiaChi});
            this.dgvThongTinChiNhanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvThongTinChiNhanh.Location = new System.Drawing.Point(0, 247);
            this.dgvThongTinChiNhanh.Name = "dgvThongTinChiNhanh";
            this.dgvThongTinChiNhanh.Size = new System.Drawing.Size(681, 162);
            this.dgvThongTinChiNhanh.TabIndex = 3;
            this.dgvThongTinChiNhanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinChiNhanh_CellClick);
            // 
            // colMaCN
            // 
            this.colMaCN.DataPropertyName = "MaCN";
            this.colMaCN.HeaderText = "Mã CN";
            this.colMaCN.Name = "colMaCN";
            // 
            // colTenCN
            // 
            this.colTenCN.DataPropertyName = "TenCN";
            this.colTenCN.HeaderText = "Tên CN";
            this.colTenCN.Name = "colTenCN";
            this.colTenCN.Width = 200;
            // 
            // colSDT
            // 
            this.colSDT.DataPropertyName = "SDT";
            this.colSDT.HeaderText = "SĐT";
            this.colSDT.Name = "colSDT";
            // 
            // colDiaChi
            // 
            this.colDiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.Name = "colDiaChi";
            // 
            // frmChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 409);
            this.Controls.Add(this.dgvThongTinChiNhanh);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.panel1);
            this.Name = "frmChiNhanh";
            this.Text = "frmChiNhanh";
            this.Load += new System.EventHandler(this.frmChiNhanh_Load);
            this.panel1.ResumeLayout(false);
            this.grbThongTinChiNhanh.ResumeLayout(false);
            this.grbThongTinChiNhanh.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiNhanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbThongTinChiNhanh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenCN;
        private System.Windows.Forms.TextBox txtMaCN;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTenCN;
        private System.Windows.Forms.Label lblMaCN;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblTim;
        private System.Windows.Forms.ToolStripTextBox txtTimMaCN;
        private System.Windows.Forms.ToolStripTextBox txtTimTenCN;
        private System.Windows.Forms.ToolStripTextBox txtTimSDT;
        private System.Windows.Forms.ToolStripTextBox txtTimDiaChi;
        private System.Windows.Forms.DataGridView dgvThongTinChiNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
    }
}