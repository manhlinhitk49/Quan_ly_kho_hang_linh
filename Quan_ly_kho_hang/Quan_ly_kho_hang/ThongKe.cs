using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_ly_kho_hang
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hangHoaTheoNSX._HangHoaTheoNSX' table. You can move, or remove it, as needed.
            this.hangHoaTheoNSXTableAdapter.Fill(this.hangHoaTheoNSX._HangHoaTheoNSX);
            // TODO: This line of code loads data into the 'nhapXuat.phieu_nhap_phieu_xuat' table. You can move, or remove it, as needed.
            this.phieu_nhap_phieu_xuatTableAdapter.Fill(this.nhapXuat.phieu_nhap_phieu_xuat);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
