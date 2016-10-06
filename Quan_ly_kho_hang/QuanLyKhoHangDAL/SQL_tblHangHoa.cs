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
        public int XoaDuLieu(EC_tblHangHoa et)
        {
            return cn.ThucThiCauLenhSQL(@"DELETE FROM tblHangHoa where MaHH=N'"+et.MaHH+"'");
        }
        
        public int TimKiem(string chuoitimkiem)
        {
            return cn.ThucThiCauLenhSQL(chuoitimkiem);
        }

    }
}
