using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using QuanLyKhoHangBUS;

namespace Quan_ly_kho_hang
{
    public partial class frmXuathang : Form
    {
        int dong = -1;
        BUS_tblHangHoa hangHoabus = new BUS_tblHangHoa();
        BUS_tblChiNhanh chiNhanhbus = new BUS_tblChiNhanh();
        BUS_tblPhieuxuat phieuxuatbus = new BUS_tblPhieuxuat();
        BUS_tblChiTietPhieuXuat chitietphieuxuatbus = new BUS_tblChiTietPhieuXuat();
        public frmXuathang()
        {
            InitializeComponent();
        }

        private void grbXuathang_Enter(object sender, EventArgs e)
        {

        }

        private void frmXuathang_Load(object sender, EventArgs e)
        {
            cmbChinhanh.DataSource = chiNhanhbus.getField("TenCN");
            cmbChinhanh.DisplayMember = "TenCN";
            //load dgvHanghoa
            DataTable tb = hangHoabus.getHH("");
            dgvHanghoa.DataSource = tb;
            
            //for (int i = 0; i < dgvHanghoa.RowCount; i++)
            //{
            //    dgvHanghoa.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            //}

        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable tb = chiNhanhbus.TaoBang(" where TenCN = '" + cmbChinhanh.Text + "'");
            if (tb.Rows.Count > 0)
            {
                lblMachinhanh.Text = tb.Rows[0]["MaCN"].ToString();
                lblDiachi.Text = tb.Rows[0]["DiaChi"].ToString();
                lblSDT.Text = tb.Rows[0]["SDT"].ToString();
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if(cmbChinhanh.Text == "")
            {
                MessageBox.Show("Chưa chọn chi nhánh!");
                    return;
            }
            List<EC_tblChiTietPhieuXuat> listChitiet = new List<EC_tblChiTietPhieuXuat>();
            List<EC_tblHangHoa> listHanghoa = new List<EC_tblHangHoa>();
            float tong = 0;
            DateTime date = DateTime.Now; 
            EC_tblPhieuXuat ecPhieuxuat = new EC_tblPhieuXuat();
            ecPhieuxuat.MaCN = lblMachinhanh.Text;
            ecPhieuxuat.NgayXuat = date.ToShortDateString();
            ecPhieuxuat.MaPX = date.Month.ToString() + date.Day.ToString() + date.Hour.ToString() + date.Minute.ToString() + date.Second.ToString();

            for(int i=0;i<dgvHanghoa.RowCount;i++)
            {
                if (dgvHanghoa.Rows[i].Cells["SoLuongXuat"].Value != null && dgvHanghoa.Rows[i].Cells["SoLuongXuat"].Value.ToString().Trim() != "")
                {
                    if (kTra(dgvHanghoa.Rows[dong].Cells["SoLuongXuat"].Value.ToString()) == 0)
                    {
                        MessageBox.Show("Nhập sai!");
                        dgvHanghoa.Rows[dong].Cells["SoLuongXuat"].Value = null;
                        return;
                    }
                    {

                        EC_tblChiTietPhieuXuat ecChitiet = new EC_tblChiTietPhieuXuat();
                        ecChitiet.MaPX = ecPhieuxuat.MaPX;
                        ecChitiet.MaHH = dgvHanghoa.Rows[i].Cells["MaHH"].Value.ToString();
                        ecChitiet.SoLuong = int.Parse(dgvHanghoa.Rows[i].Cells["SoLuongXuat"].Value.ToString());
                        ecChitiet.DonGia = int.Parse(dgvHanghoa.Rows[i].Cells["GiaXuat"].Value.ToString());

                        listChitiet.Add(ecChitiet);
                        tong += ecChitiet.SoLuong * ecChitiet.DonGia;

                        EC_tblHangHoa ecHanghoa = new EC_tblHangHoa();
                        ecHanghoa.MaHH = dgvHanghoa.Rows[i].Cells["MaHH"].Value.ToString();
                        ecHanghoa.SoLuong = int.Parse(dgvHanghoa.Rows[i].Cells["SoLuong"].Value.ToString()) - int.Parse(dgvHanghoa.Rows[i].Cells["SoLuongXuat"].Value.ToString());
                        if (ecHanghoa.SoLuong < 0)
                        {
                            MessageBox.Show("Không đủ hàng để xuất!");
                            dgvHanghoa.Rows[i].Cells["SoLuongXuat"].Value = null;
                            return;
                        }
                        listHanghoa.Add(ecHanghoa);
                    }
                }
            }
            if(tong == 0)
            {
                MessageBox.Show("Chưa chọn hàng để xuất !");
                return;
            }
            ecPhieuxuat.TongTien = tong;
            phieuxuatbus.ThemDuLieu(ecPhieuxuat);
            
            foreach (var ec in listChitiet)
            {
                chitietphieuxuatbus.ThemDuLieu(ec);
            }
            
            foreach (var ec in listHanghoa)
            {
                hangHoabus.SuaSoLuong(ec);
            }
            
            MessageBox.Show(String.Format("OK!\n Tổng tiền là : {0:10}",tong));
            DataTable tb = chiNhanhbus.TaoBang(" where TenCN = '" + cmbChinhanh.Text + "'");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            for(int i = 0 ; i<dgvHanghoa.RowCount; i++)
            {
                dgvHanghoa.Rows[i].Cells["SoLuongXuat"].Value = null;
            }
        }
        private void dgvHanghoa_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHanghoa.Rows[dong].Cells["SoLuongXuat"].Value != null)
            {
                if (kTra(dgvHanghoa.Rows[dong].Cells["SoLuongXuat"].Value.ToString()) == 1)
                {
                    int tien = int.Parse(dgvHanghoa.Rows[dong].Cells["SoLuongXuat"].Value.ToString()) * int.Parse(dgvHanghoa.Rows[dong].Cells["GiaXuat"].Value.ToString());
                    dgvHanghoa.Rows[dong].Cells["TongTien"].Value = tien.ToString();
                }
                else
                {
                    dgvHanghoa.Rows[dong].Cells["SoLuongXuat"].Style.ForeColor = Color.Red;
                }
            }

        }

        private void dgvHanghoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }
        public int kTra(string str)
        {
            str.Trim();
            for(int i = 0 ;  i<str.Length; i++)
            {
                if (str[i] < 48 || str[i] > 57) return 0;
            }
            return 1;
        }

        private void dgvHanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if(cmbChinhanh.Text =="")
            {
                MessageBox.Show("Chưa chọn chi nhánh!");
                return;
            }
            frmLichsuxuat frm = new frmLichsuxuat(cmbChinhanh.Text);
            frm.Show();
            this.Dispose();
        }
    }
}
