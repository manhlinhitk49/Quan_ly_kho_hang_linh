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
    public partial class frmNhaCungCap : Form
    {
        EC_tblNhaCungCap ec = new EC_tblNhaCungCap();
        BUS_tblNhaCungCap bus = new BUS_tblNhaCungCap();
        private bool themmoi;
        void SetNull()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void KhoaDieuKhien()
        {
            txtMaNCC.ReadOnly = true;
            txtTenNCC.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

        }
        private void MoDieuKhien()
        {
            txtMaNCC.ReadOnly = false;
            txtTenNCC.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;

        }
        public frmNhaCungCap()
        {
            InitializeComponent();
        }
        private void HienThi(string where)
        {
            dgvDanhSach.DataSource = bus.getNhaCungCap(where);
        }
        void TuDanhMaNCC()//ham này dùng trong trường hợp thêm tb thì nếu chỉ nhập tên tb thì sẽ tự động đánh MaTB
        {
            DataTable MaNCC;
            MaNCC = bus.LayRaMaNCC();
            txtMaNCC.DataBindings.Clear();
            txtMaNCC.DataBindings.Add("Text", MaNCC, "MaNCC", true);
            string MP = txtMaNCC.Text;
            int stt = int.Parse(MP.Substring(3, MP.Length - 3)) + 1;
            if (stt < 10) { txtMaNCC.Text = MP.Substring(0, 3) + "0" + stt.ToString(); }
            else txtMaNCC.Text = MP.Substring(0, 3) + stt.ToString();

        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThi("");
            KhoaDieuKhien();
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                txtMaNCC.Text = dgvDanhSach.Rows[dong].Cells[0].Value.ToString();
                txtTenNCC.Text = dgvDanhSach.Rows[dong].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvDanhSach.Rows[dong].Cells[2].Value.ToString();
                txtSDT.Text = dgvDanhSach.Rows[dong].Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DataTable tbl = bus.getNhaCungCap("");
            dgvDanhSach.DataSource = tbl;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kich hoat cac chuc năng
            /*btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;*/
            
            MoDieuKhien();
            SetNull();
            TuDanhMaNCC();
            txtMaNCC.ReadOnly = true;
            themmoi = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            txtMaNCC.ReadOnly = true;
            themmoi = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa không??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (xacnhan == DialogResult.OK)
            {
                ec.MaNCC= txtMaNCC.Text;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "" || txtTenNCC.Text == "" || txtDiaChi.Text == "" )
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
                        ec.MaNCC = txtMaNCC.Text;
                        ec.TenNCC = txtTenNCC.Text;
                        ec.DiaChi = txtDiaChi.Text;
                        ec.SDT= txtSDT.Text;

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
                        ec.MaNCC = txtMaNCC.Text;
                        ec.TenNCC = txtTenNCC.Text;
                        ec.DiaChi = txtDiaChi.Text;
                        ec.SDT = txtSDT.Text;
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

    }
}
