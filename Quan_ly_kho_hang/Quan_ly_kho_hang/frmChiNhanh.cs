using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKhoHangBUS;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;


namespace Quan_ly_kho_hang
{
    public partial class frmChiNhanh : Form
    {
        private bool _them = false;
        private bool _codulieu = false;
        private bool _online = false;
        private bool _dangTimMaCN = false;
        private bool _dangTimTenCN = false;
        private bool _dangTimDiaChi = false;
        private bool _dangTimSDT = false;

        private BUS_tblChiNhanh busCN = new BUS_tblChiNhanh();
        private EC_tblChiNhanh etCN = new EC_tblChiNhanh();
        public frmChiNhanh()
        {
            InitializeComponent();
        }

        private void dgvThongTinChiNhanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvThongTinChiNhanh.Rows.Count - 1)
            {
                txtMaCN.Text = dgvThongTinChiNhanh.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenCN.Text = dgvThongTinChiNhanh.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvThongTinChiNhanh.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSDT.Text = dgvThongTinChiNhanh.Rows[e.RowIndex].Cells[3].Value.ToString();               
            }
            if (e.RowIndex >= dgvThongTinChiNhanh.Rows.Count - 1)
            {
                txtMaCN.ResetText();
                txtTenCN.ResetText();
                txtDiaChi.ResetText();
                txtTenCN.ResetText();
            }
        }
        private void frmChiNhanh_Load(object sender, EventArgs e)
        {
            DataTable tbl = busCN.TaoBang("");
            dgvThongTinChiNhanh.DataSource = tbl;
            dgvThongTinChiNhanh.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            btnThoat.Text = "Quay lại";
            dgvThongTinChiNhanh.Enabled = false;
            txtMaCN.ReadOnly = false;
            txtTenCN.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;

            txtMaCN.ResetText();
            txtTenCN.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();

            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLamMoi.Enabled = false;
            btnLuu.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            if (txtMaCN.Text != "")
            {
                //sua text nut thoat
                btnThoat.Text = "Quay lại";
                //kich hoat cac txt nhap
                txtTenCN.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                txtSDT.ReadOnly = false;
                
                //khoa, kich hoat cac nut dieu khien
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnLamMoi.Enabled = false;
                btnLuu.Enabled = true;

                btnLuu.Enabled = true;
                //khoa datagridview
                dgvThongTinChiNhanh.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                etCN.MaCN = txtMaCN.Text;
                //xoa tat ca du lieu lien quan den NV?????????????
                string thongbao = busCN.XoaDuLieu(etCN);
                if (thongbao != "")
                {
                    MessageBox.Show("Không thể thực hiện!!!\n" + thongbao, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                btnLamMoi_Click(null, null);
            }          
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DataTable tbl = busCN.TaoBang("");
            dgvThongTinChiNhanh.DataSource = tbl;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (btnLuu.Enabled)
            {
                btnThoat.Text = "Thoát";
                //mo lai datagridview
                dgvThongTinChiNhanh.Enabled = true;
                //khoa cac txt nhap
                txtMaCN.ReadOnly = true;
                txtTenCN.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtSDT.ReadOnly = true;
               
                //chinh trang thai cac nut
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                btnLamMoi.Enabled = true;
                //reset
                btnLamMoi_Click(sender, e);
            }
            else
            {
                //update du lieu
                _online = false;
                this.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool _kt = true;
            txtMaCN.Text = txtMaCN.Text.ToUpper();
            if (_them)
            {
                for (int _i = 0; _i < dgvThongTinChiNhanh.RowCount - 1; _i++)
                {
                    if (txtMaCN.Text == dgvThongTinChiNhanh.Rows[_i].Cells[0].Value.ToString())
                    {
                        _kt = false;
                        break;
                    }
                }
            }
            if (_kt)
            {
                if (txtMaCN.Text != "")
                {
                    //Sua text nut thoat
                    btnThoat.Text = "Thoát";
                    //mo lai datagridview
                    dgvThongTinChiNhanh.Enabled = true;
                    //update co so du lieu
                    etCN.MaCN = txtMaCN.Text;
                    etCN.TenCN = txtTenCN.Text;
                    etCN.DiaChi = txtDiaChi.Text;
                    etCN.SDT = txtSDT.Text;
                                      
                    //kiem tra thao tac la them hay sua
                    if (_them == false) busCN.SuaDuLieu(etCN);
                    else busCN.ThemDuLieu(etCN);
                    //khoa cac txt nhap
                    txtMaCN.ReadOnly = true;
                    txtDiaChi.ReadOnly = true;
                    txtSDT.ReadOnly = true;
                    txtTenCN.ReadOnly = true;
                   
                    //chinh trang thai cac nut
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    btnLamMoi.Enabled = true;

                    btnLuu.Enabled = false;
                    //lam moi datagtidview
                    btnLamMoi_Click(sender, e);
                    _codulieu = false;
                }
                else
                {
                    MessageBox.Show("Không có mã chi nhánh!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Mã chi nhánh đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void txtMaCN_TextChanged(object sender, EventArgs e)
        {
            if (btnLuu.Enabled)
            {
                _codulieu = true;
            }
        }

        private void txtTenCN_TextChanged(object sender, EventArgs e)
        {
            if (btnLuu.Enabled)
            {
                _codulieu = true;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (btnLuu.Enabled)
            {
                _codulieu = true;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (btnLuu.Enabled)
            {
                _codulieu = true;
            }
        }

        private void txtMaCN_Enter(object sender, EventArgs e)
        {
            txtMaCN.SelectionStart = txtMaCN.Text.Length;
        }

        private void txtTenCN_Enter(object sender, EventArgs e)
        {
            txtTenCN.SelectionStart = txtTenCN.Text.Length;
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            txtSDT.SelectionStart = txtSDT.Text.Length;
        }

        private void txtDiaChi_Enter(object sender, EventArgs e)
        {
            txtDiaChi.SelectionStart = txtDiaChi.Text.Length;
        }

        private void txtTimMaCN_Click(object sender, EventArgs e)
        {
            if (_dangTimMaCN)
            {
                txtMaCN.SelectionStart = txtMaCN.Text.Length;
            }
            else
            {
                txtMaCN.SelectAll();
            }
        }

        private void txtTimTenCN_Click(object sender, EventArgs e)
        {
            if (_dangTimTenCN)
            {
                txtTenCN.SelectionStart = txtTenCN.Text.Length;
            }
            else
            {
                txtTenCN.SelectAll();
            }
        }

        private void txtTimSDT_Click(object sender, EventArgs e)
        {
            if (_dangTimSDT)
            {
                txtSDT.SelectionStart = txtSDT.Text.Length;
            }
            else
            {
                txtSDT.SelectAll();
            }
        }

        private void txtTimDiaChi_Click(object sender, EventArgs e)
        {
            if (_dangTimDiaChi)
            {
                txtDiaChi.SelectionStart = txtDiaChi.Text.Length;
            }
            else
            {
                txtDiaChi.SelectAll();
            }
        }

        private void txtTimMaCN_TextChanged(object sender, EventArgs e)
        {
            if (txtTimMaCN.Text != "") _dangTimMaCN = true;
            else _dangTimMaCN = false;
            string dieukien = "where MaCN like N'%" + txtTimMaCN.Text + "%'";
            if (_dangTimTenCN) dieukien += "AND TenCN like N'%" + txtTenCN.Text + "%'";            
            if (_dangTimDiaChi) dieukien += "AND DiaChi like N'%" + txtDiaChi.Text + "%'";
            if (_dangTimSDT) dieukien += "AND SDT like N'%" + txtSDT.Text + "%'";
            DataTable tbl = busCN.TaoBang(dieukien);
            dgvThongTinChiNhanh.DataSource = tbl;
        }

        private void txtTimTenCN_TextChanged(object sender, EventArgs e)
        {
            if (txtTimTenCN.Text != "") _dangTimTenCN = true;
            else _dangTimTenCN = false;
            string dieukien = "where TenCN like N'%" + txtTimTenCN.Text + "%'";
            if (_dangTimMaCN) dieukien += "AND MaCN like N'%" + txtMaCN.Text + "%'";
            if (_dangTimDiaChi) dieukien += "AND DiaChi like N'%" + txtDiaChi.Text + "%'";
            if (_dangTimSDT) dieukien += "AND SDT like N'%" + txtSDT.Text + "%'";
            DataTable tbl = busCN.TaoBang(dieukien);
            dgvThongTinChiNhanh.DataSource = tbl;
        }

        private void txtTimSDT_TextChanged(object sender, EventArgs e)
        {            
            if (txtTimSDT.Text != "") _dangTimSDT = true;
            else _dangTimSDT = false;
            string dieukien = "where SDT like N'%" + txtTimSDT.Text + "%'";
            if (_dangTimMaCN) dieukien += "AND MaCN like N'%" + txtMaCN.Text + "%'";
            if (_dangTimTenCN) dieukien += "AND TenCN like N'%" + txtTenCN.Text + "%'";
            if (_dangTimDiaChi) dieukien += "AND DiaChi like N'%" + txtDiaChi.Text + "%'";
            DataTable tbl = busCN.TaoBang(dieukien);
            dgvThongTinChiNhanh.DataSource = tbl;
        }

        private void txtTimDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtTimDiaChi.Text != "") _dangTimDiaChi = true;
            else _dangTimDiaChi = false;
            string dieukien = "where DiaChi like N'%" + txtTimDiaChi.Text + "%'";
            if (_dangTimMaCN) dieukien += "AND MaCN like N'%" + txtMaCN.Text + "%'";
            if (_dangTimTenCN) dieukien += "AND TenCN like N'%" + txtTenCN.Text + "%'";
            if (_dangTimSDT) dieukien += "AND SDT like N'%" + txtSDT.Text + "%'";            
            DataTable tbl = busCN.TaoBang(dieukien);
            dgvThongTinChiNhanh.DataSource = tbl;
        }
    }
}
