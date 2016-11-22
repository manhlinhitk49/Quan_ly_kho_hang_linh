namespace Quan_ly_kho_hang
{
    partial class frmThongKe
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nhapXuat = new Quan_ly_kho_hang.Dataset.NhapXuat();
            this.phieunhapphieuxuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phieu_nhap_phieu_xuatTableAdapter = new Quan_ly_kho_hang.Dataset.NhapXuatTableAdapters.phieu_nhap_phieu_xuatTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hangHoaTheoNSX = new Quan_ly_kho_hang.Dataset.HangHoaTheoNSX();
            this.hangHoaTheoNSXBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTheoNSXTableAdapter = new Quan_ly_kho_hang.Dataset.HangHoaTheoNSXTableAdapters.HangHoaTheoNSXTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhapXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapphieuxuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaTheoNSX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaTheoNSXBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(602, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.phieunhapphieuxuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Quan_ly_kho_hang.Report.nhapxuat.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(596, 336);
            this.reportViewer1.TabIndex = 0;
            // 
            // nhapXuat
            // 
            this.nhapXuat.DataSetName = "NhapXuat";
            this.nhapXuat.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phieunhapphieuxuatBindingSource
            // 
            this.phieunhapphieuxuatBindingSource.DataMember = "phieu_nhap_phieu_xuat";
            this.phieunhapphieuxuatBindingSource.DataSource = this.nhapXuat;
            // 
            // phieu_nhap_phieu_xuatTableAdapter
            // 
            this.phieu_nhap_phieu_xuatTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.hangHoaTheoNSXBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Quan_ly_kho_hang.Report.sltheonsx.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(596, 336);
            this.reportViewer2.TabIndex = 0;
            // 
            // hangHoaTheoNSX
            // 
            this.hangHoaTheoNSX.DataSetName = "HangHoaTheoNSX";
            this.hangHoaTheoNSX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaTheoNSXBindingSource
            // 
            this.hangHoaTheoNSXBindingSource.DataMember = "HangHoaTheoNSX";
            this.hangHoaTheoNSXBindingSource.DataSource = this.hangHoaTheoNSX;
            // 
            // hangHoaTheoNSXTableAdapter
            // 
            this.hangHoaTheoNSXTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 368);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhapXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieunhapphieuxuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaTheoNSX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaTheoNSXBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private Dataset.NhapXuat nhapXuat;
        private System.Windows.Forms.BindingSource phieunhapphieuxuatBindingSource;
        private Dataset.NhapXuatTableAdapters.phieu_nhap_phieu_xuatTableAdapter phieu_nhap_phieu_xuatTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Dataset.HangHoaTheoNSX hangHoaTheoNSX;
        private System.Windows.Forms.BindingSource hangHoaTheoNSXBindingSource;
        private Dataset.HangHoaTheoNSXTableAdapters.HangHoaTheoNSXTableAdapter hangHoaTheoNSXTableAdapter;

    }
}