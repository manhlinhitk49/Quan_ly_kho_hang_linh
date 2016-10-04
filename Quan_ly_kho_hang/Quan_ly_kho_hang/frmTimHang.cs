using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKhoHangDAL;

namespace Quan_ly_kho_hang
{
    public partial class frmTimHang : Form
    {
        public frmTimHang()
        {
            InitializeComponent();
        }

        private SQL_tblHangHoa DAL_Hang = new SQL_tblHangHoa();
        private string dauNhap = "=";
        private string dauXuat = "=";

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtGiaNhap.ResetText();
            txtGiaXuat.ResetText();
            txtMa.ResetText();
            txtNSX.ResetText();
            txtTen.ResetText();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string chuoitim = "select * from tblHangHoa";
            bool chuacodieukien = true;
            if (txtTen.Text != "" || txtNSX.Text != "" || txtMa.Text != "" || txtGiaXuat.Text!= "" || txtGiaNhap.Text!= "" )
            {
                chuoitim += " where ";
                //mahh
                if (txtMa.Text != "")
                {
                    chuoitim += "MaHH like '%" + txtMa.Text + "%'";
                    chuacodieukien = false;
                }
                //tenhh
                if (txtTen.Text != "" && chuacodieukien)
                {
                    chuoitim += "TenHH like '%" + txtTen.Text + "%'";
                    chuacodieukien = false;
                }
                else
                    if (txtTen.Text != "")
                    {
                        chuoitim += " and TenHH like '%" + txtTen.Text + "%'";
                    }
                //gianhap
                if (txtGiaNhap.Text != "" && chuacodieukien)
                {
                    chuoitim += "GiaNhap " + dauNhap + " " + txtGiaNhap.Text;
                    chuacodieukien = false;
                }
                else
                    if (txtGiaNhap.Text != "")
                    {
                        chuoitim += " and GiaNhap " + dauNhap + " " + txtGiaNhap.Text;
                    }
                //giaxuat
                if (txtGiaXuat.Text != "" && chuacodieukien)
                {
                    chuoitim += "GiaXuat " + dauXuat + " " + txtGiaXuat.Text;
                    chuacodieukien = false;
                }
                else
                    if (txtGiaXuat.Text != "")
                    {
                        chuoitim += " and GiaXuat " + dauXuat + " " + txtGiaXuat.Text;
                    }
                //nsx
                if (txtNSX.Text != "" && chuacodieukien)
                {
                    chuoitim += "NSX like N'%" + txtNSX.Text + "%'";
                    chuacodieukien = false;
                }
                else
                    if (txtNSX.Text != "")
                    {
                        chuoitim += " and NSX like N'%" + txtNSX.Text + "%'";
                    }
            }

            dgvDanhSach.DataSource = DAL_Hang.TimKiem(chuoitim);
        }

        private void frmTimHang_Load(object sender, EventArgs e)
        {
            cboNhap.SelectedIndex = 0;
            cboXuat.SelectedIndex = 0;
        }

        private void cboNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            dauNhap = cboNhap.SelectedItem.ToString();
        }

        private void cboXuat_SelectedIndexChanged(object sender, EventArgs e)
        {
            dauXuat = cboXuat.SelectedItem.ToString();
        }
    }
}
