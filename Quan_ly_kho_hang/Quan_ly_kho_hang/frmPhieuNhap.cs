using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
namespace Quan_ly_kho_hang
{
    public partial class frmPhieuNhap : Form
    {
        SQL_tblChiTietPhieuNhap ctpn = new SQL_tblChiTietPhieuNhap();
        SQL_tblPhieuNhap pn = new SQL_tblPhieuNhap();
        EC_tblChiTietPhieuNhap ct = new EC_tblChiTietPhieuNhap();
        bool themmoi = false;
        void SetNull()
        {
            //chi tiet phieu nhap
            txtCTMaPH.Text = "";
            txtMaHH.Text = "";
            txtTen.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            // phieu nhap;
            txtMaPH.Text = "";
            txtNCC.Text = "";
            txtNgayNhap.Text = "";
            txtTongTien.Text = "";
        }
        public frmPhieuNhap()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            grv_CTPN.DataSource = ctpn.getChitiet();         
        }

        private void grv_CTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;/*biến dòng :kich vào dòng thì chỉ số dòng đc lưu vào biến dòng */
                txtCTMaPH.Text = grv_CTPN.Rows[dong].Cells[0].Value.ToString();
                txtMaHH.Text = grv_CTPN.Rows[dong].Cells[1].Value.ToString();
                txtTen.Text = grv_CTPN.Rows[dong].Cells[2].Value.ToString();
                txtSoLuong.Text = grv_CTPN.Rows[dong].Cells[3].Value.ToString();
                txtDonGia.Text = grv_CTPN.Rows[dong].Cells[4].Value.ToString();              
            }
            catch
            {

            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void KhoaDieuKhien()
        {
            txtCTMaPH.ReadOnly = true;
            txtMaHH.ReadOnly = true;
            txtTen.ReadOnly = true;
            txtSoLuong.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            //button
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            btnRefresh.Enabled = false;
            btnSave.Enabled = false;
        }

        public void MoDieuKhien()
        {
            txtCTMaPH.ReadOnly = false;
            txtMaHH.ReadOnly = false;
            txtTen.ReadOnly = false;
            txtSoLuong.ReadOnly = false;
            txtDonGia.ReadOnly = false;            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            themmoi = false;
            MoDieuKhien();
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnXem.Enabled = false;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            txtMaPH.Text = txtCTMaPH.Text;
            LoadPN();
            dgvHH.DataSource = ctpn.getChitietHH(txtMaPH.Text);
        }
        public void LoadPN()
        {
            DataTable dt = new DataTable();
            dt = pn.getPN(txtCTMaPH.Text);
            txtNCC.Text = dt.Rows[0][0].ToString();
            txtNgayNhap.Text = dt.Rows[0][1].ToString();
            txtTongTien.Text = dt.Rows[0][2].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát???","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) this.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (themmoi == false)      //đang ở trạng thái sửa dữ liệu
            {
                ct.MaPN = txtCTMaPH.Text;
                ct.MaHH = txtMaHH.Text;
                ct.SoLuong = int.Parse(txtSoLuong.Text);
                ct.DonGia = int.Parse(txtDonGia.Text);
                ctpn.Sua(ct);
                btnAdd.Enabled = true;
                btnXem.Enabled = true;
                btnDel.Enabled = true;
            }
            else                         // đang ở trạng thái thêm dữ liệu
            {
                ct.MaPN = txtCTMaPH.Text;
                ct.MaHH = txtMaHH.Text;
                ct.SoLuong = int.Parse(txtSoLuong.Text);
                ct.DonGia = int.Parse(txtDonGia.Text);
                ctpn.Them(ct);
                MessageBox.Show("Bạn đã thêm vào phiếu nhập thành cônng", "Thông Báo", MessageBoxButtons.OK);
            }            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            KhoaDieuKhien();
            SetNull();
            grv_CTPN.DataSource = ctpn.getChitiet();
            pn.CapNhatTongTien();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            themmoi = true;
            SetNull();
            MoDieuKhien();
            txtTen.ReadOnly = true;
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            btnSave.Enabled = true;
            btnRefresh.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ct.MaPN = txtCTMaPH.Text;
            ct.MaHH = txtMaHH.Text;
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn xóa?","Questions",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                ctpn.Xoa(ct);
                SetNull();
                grv_CTPN.DataSource = ctpn.getChitiet();
            }
        }
    }
}
