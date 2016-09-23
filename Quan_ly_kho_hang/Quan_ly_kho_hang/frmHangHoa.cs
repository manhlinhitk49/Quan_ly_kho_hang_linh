using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLyKhoHangBUS;
using QuanLyKhoHangEntity;

namespace Quan_ly_kho_hang
{
    public partial class frmHangHoa : Form
    {
        BUS_tblHangHoa bus = new BUS_tblHangHoa();
        EC_tblHangHoa ec = new EC_tblHangHoa();
        private DataTable tblHangHoa= new DataTable();
        private bool themmoi;
        void SetNull()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            txtGiaXuat.Text = "";
            txtNSX.Text = "";
            txtThongTin.Text = "";
        }
        private void KhoaDieuKhien()
        {
            txtMaHH.ReadOnly = true;
            txtTenHH.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtGiaNhap.ReadOnly = true;
            txtGiaXuat.ReadOnly = true;
            txtNSX.ReadOnly = true;
            txtThongTin.ReadOnly = true;

            btnThem.Enabled = true;
            btnSuaThongTin.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }
        private void MoDieuKhien()
        {
            txtMaHH.ReadOnly = false;
            txtTenHH.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtGiaNhap.ReadOnly = false;
            txtGiaXuat.ReadOnly = false;
            txtNSX.ReadOnly = false;
            txtThongTin.ReadOnly = false;

        }
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void HienThi(string where)
        {
            dgvDanhSach.DataSource = bus.TaoBang(where);
        }
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                txtMaHH.Text = dgvDanhSach.Rows[dong].Cells[0].Value.ToString();
                txtTenHH.Text = dgvDanhSach.Rows[dong].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvDanhSach.Rows[dong].Cells[2].Value.ToString();
                txtGiaNhap.Text = dgvDanhSach.Rows[dong].Cells[3].Value.ToString();
                txtGiaXuat.Text = dgvDanhSach.Rows[dong].Cells[4].Value.ToString();
                txtNSX.Text = dgvDanhSach.Rows[dong].Cells[5].Value.ToString();
                txtThongTin.Text = dgvDanhSach.Rows[dong].Cells[6].Value.ToString();
            }
            catch
            {
            }
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            HienThi("");
            KhoaDieuKhien();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kich hoat cac chuc năng
            btnSuaThongTin.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            //khoi tao ve gia tri ban dau
            /*txtMaHH.ResetText();
            txtSoLuong.ResetText();
            txtGiaXuat.ResetText();
            txtGiaNhap.ResetText();
            txtNSX.ResetText();
            txtThongTin.ResetText();*/
            txtMaHH.Focus();
            MoDieuKhien();
            SetNull();
            themmoi = true;
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            //kich hoat cac chuc năng
            btnThem.Enabled = false;
            btnSuaThongTin.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            MoDieuKhien();
            txtMaHH.ReadOnly=true;
            themmoi=false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                ec.MaHH = txtMaHH.Text;
                if (bus.XoaDuLieu(ec) == 0)
                {

                    MessageBox.Show("Không thể xoá!!!", "Thông báo???", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    bus.XoaDuLieu(ec);
                    MessageBox.Show("Đã xóa thành công!");
                    btnLamMoi_Click(sender, e);
                    SetNull();

                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DataTable tbl = bus.TaoBang("");
            dgvDanhSach.DataSource = tbl;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHH.Text == "" || txtTenHH.Text == "" || txtSoLuong.Text == "" || txtGiaNhap.Text == "" || txtGiaXuat.Text == "" || txtNSX.Text == "" || txtThongTin.Text == "")
            {
                MessageBox.Show("Xin mời nhập thông tin đầy đủ");
                KhoaDieuKhien();
                return;
            }
            else
            {
                if (themmoi == true)/*đang ở trang thái thêm mới*/
                {
                    try
                    {
                        ec.MaHH = txtMaHH.Text;
                        ec.TenHH = txtTenHH.Text;
                        ec.SoLuong = int.Parse(txtSoLuong.Text);
                        ec.GiaNhap = int.Parse(txtGiaNhap.Text);
                        ec.GiaXuat = int.Parse(txtGiaXuat.Text);
                        ec.NSX = txtNSX.Text;
                        ec.ThongTin = txtThongTin.Text;

                        bus.ThemDuLieu(ec);
                        MessageBox.Show("Đã thêm mới thành công");/*dòng thông báo*/
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }

                }
                else
                {
                    try
                    {
                        ec.MaHH = txtMaHH.Text;
                        ec.TenHH = txtTenHH.Text;
                        ec.SoLuong = int.Parse(txtSoLuong.Text);
                        ec.GiaNhap = int.Parse(txtGiaNhap.Text);
                        ec.GiaXuat = int.Parse(txtGiaXuat.Text);
                        ec.NSX = txtNSX.Text;
                        ec.ThongTin = txtThongTin.Text;
                        bus.SuaDuLieu(ec);
                        MessageBox.Show("Đã sửa thành công");

                    }
                    catch
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                }
                SetNull();
                KhoaDieuKhien();/*không cho thao tác*/
                HienThi("");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            SetNull();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
