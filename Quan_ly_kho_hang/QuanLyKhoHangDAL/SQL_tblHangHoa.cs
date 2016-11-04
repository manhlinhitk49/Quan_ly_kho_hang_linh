using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangDAL
{
    public class SQL_tblHangHoa
    {
        KetNoiData cn = new KetNoiData();
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * from tblHangHoa " + DieuKien);
        }
        public int ThemDuLieu(EC_tblHangHoa et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO tblHangHoa (MaHH, TenHH, SoLuong, GiaNhap, GiaXuat, NSX, ThongTin) 
            VALUES(N'"+et.MaHH+"',N'"+et.TenHH+"','"+et.SoLuong+"','"+et.GiaNhap+"','"+et.GiaXuat+"',N'"+et.NSX+"',N'"+et.ThongTin+"')");
        }
        public int SuaDuLieu(EC_tblHangHoa et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE tblHangHoa SET TenHH =N'"+et.TenHH+"', SoLuong ='"+et.SoLuong+"', GiaNhap ='"+et.GiaNhap+"', GiaXuat ='"+
                et.GiaXuat+"', NSX =N'"+et.NSX+"', ThongTin =N'"+et.ThongTin+"' where MaHH=N'"+et.MaHH+"'");
        }
        public int SuaSoLuong(EC_tblHangHoa et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE tblHangHoa SET SoLuong =" + et.SoLuong + " where MaHH = N'" + et.MaHH + "'");
        }
        public int XoaDuLieu(EC_tblHangHoa et)
        {
            return cn.ThucThiCauLenhSQL(@"DELETE FROM tblHangHoa where MaHH=N'"+et.MaHH+"'");
        }

        public DataTable getHH(string dk)
        {
            /*return cn.GetDataTable(@"select h.MaHH,TenHH,  NSX, ThongTin, SoLuong, GiaXuat, t.NgayXuat from tblHangHoa h left join 
(select p.NgayXuat, c.MaHH from tblPhieuXuat p, tblChiTietPhieuXuat c where p.MaPX = c.MaPX ) t 
on t.MaHH =  h.MaHH and SoLuong > 0" + dk);*/
            return cn.GetDataTable(@"select h.MaHH,TenHH,  NSX, ThongTin, h.SoLuong, GiaXuat from tblHangHoa h
where h.MaHH =  h.MaHH and h.SoLuong > 0"+ dk);
        }
        public DataTable getHistory(string dk)
        {
            return cn.GetDataTable(@"select h.MaHH,TenHH,  NSX, ThongTin, t.SoLuong, GiaXuat, t.NgayXuat from tblHangHoa h, (select p.NgayXuat, c.MaHH, p.MaCN, c.SoLuong from tblPhieuXuat p, tblChiTietPhieuXuat c where p.MaPX = c.MaPX ) t 
where t.MaHH =  h.MaHH and t.SoLuong >0" + dk);
        }
        
    }
}
