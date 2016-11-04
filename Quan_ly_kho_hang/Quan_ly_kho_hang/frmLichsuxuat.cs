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
    public partial class frmLichsuxuat : Form
    {

        BUS_tblChiNhanh busChinhanh = new BUS_tblChiNhanh();
        BUS_tblHangHoa busHanghoa = new BUS_tblHangHoa();
        public frmLichsuxuat()
        {
            InitializeComponent();
        }
        public frmLichsuxuat(string Tenchinhanh)
        {
            InitializeComponent();
            lblChinhanh.Text = Tenchinhanh;
        }

        private void frmLichsuxuat_Load(object sender, EventArgs e)
        {
            DataTable tb = busChinhanh.TaoBang(" where TenCN = '" + lblChinhanh.Text + "'");
            if (tb.Rows.Count > 0)
            {
                lblMachinhanh.Text = tb.Rows[0]["MaCN"].ToString();
                lblDiachi.Text = tb.Rows[0]["DiaChi"].ToString();
                lblSDT.Text = tb.Rows[0]["SDT"].ToString();
            }
            tb = busHanghoa.getHistory(" and MaCN = '"+lblMachinhanh.Text+"'");
            dgvHanghoa.DataSource = tb;
            
            for(int i =0;i<dgvHanghoa.RowCount;i++)
            {
                dgvHanghoa.Rows[i].Cells["STT"].Value = i+1;
                dgvHanghoa.Rows[i].Cells["TongTien"].Value = int.Parse(dgvHanghoa.Rows[i].Cells["SoLuong"].Value.ToString()) + int.Parse(dgvHanghoa.Rows[i].Cells["GiaXuat"].Value.ToString());
            }
            
        }

        private void frmLichsuxuat_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmXuathang frm = new frmXuathang();
            frm.Show();
            this.Dispose();
        }
    }
}
