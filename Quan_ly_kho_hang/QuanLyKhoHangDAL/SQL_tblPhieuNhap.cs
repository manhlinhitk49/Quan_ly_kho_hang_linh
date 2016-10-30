using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhoHangEntity;
namespace QuanLyKhoHangDAL
{
    public class SQL_tblPhieuNhap
    {
        KetNoiData cn = new KetNoiData();
        public DataTable getPhieuNhap()
        {
            return cn.GetDataTable(@"SELECT * from tblPhieuNhap");
        }
        public void Them(EC_tblPhieuNhap et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblPhieuNhap (MaPN,MaNCC,NgayNhap) VALUES ('"+et.MaPN+"','"+et.MaNCC+"','"+et.NgayNhap+"')");
        }
        public void Sua(EC_tblPhieuNhap et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblPhieuNhap SET MANCC = '"+et.MaNCC+"',NgayNhap = '"+et.NgayNhap+"' where MaPN = '"+et.MaPN+"'");
        }
        public void Xoa(EC_tblPhieuNhap et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblPhieuNhap where MaPN = '"+et.MaPN+"'");
        }
        public DataTable getPN(string value)
        {
            return cn.GetDataTable(@"SELECT b.TenNCC, a.NgayNhap, a.TongTien from tblPhieuNhap a, tblNhaCungCap b where a.MaNCC = b.MaNCC and MaPN = '"+value+"'");
        }
        public void CapNhatTongTien()
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblPhieuNhap SET TongTien = (select sum(a.ThanhTien) from tblChiTietPhieuNhap a where a.MaPN = tblPhieuNhap.MaPN)");
        }
    }
}
