using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhoHangEntity;
namespace QuanLyKhoHangDAL
{
    public class SQL_tblChiTietPhieuNhap
    {
        KetNoiData cn = new KetNoiData();
        public DataTable getALLChiTietPhieuNhap()
        {
            return cn.GetDataTable(@"SELECT * from tblChiTietPhieuNhap");
        }
        public void Them(EC_tblChiTietPhieuNhap et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO tblChiTietPhieuNhap (MaPN,MaHH,SoLuong,DonGia) VALUES ('" + et.MaPN + "','" + et.MaHH + "'," + et.SoLuong + "," + et.DonGia + ")");
        }
        public void Sua(EC_tblChiTietPhieuNhap et)
        {
            cn.ThucThiCauLenhSQL(@"UPDATE tblChiTietPhieuNhap SET SoLuong =  " + et.SoLuong + " , DonGia = " + et.DonGia + " where MaPN = '" + et.MaPN + "' and MAHH = '" + et.MaHH + "'");
        }
        public void Xoa(EC_tblChiTietPhieuNhap et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE FROM tblChiTietPhieuNhap where MaPN = '" + et.MaPN + "'and MaHH = '"+et.MaHH+"'");
        }
        public DataTable getChitiet()
        {
            return cn.GetDataTable(@"SELECT a.MaPN,a.MaHH,b.TenHH,a.SoLuong,a.DonGia,a.ThanhTien FROM tblChiTietPhieuNhap a,tblHangHoa b WHERE a.MaHH = b.MaHH ");
        }
        public DataTable getChitietHH(string value)
        {
            return cn.GetDataTable(@"select a.MaHH,b.TenHH,a.SoLuong,a.DonGia from tblChiTietPhieuNhap a,tblHangHoa b where a.MaHH = b.MaHH and a.MaPN = '"+value+"'");
        }
    }
}
