using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangEntity;
using System.Data;


namespace QuanLyKhoHangDAL
{
    public class SQL_tblChiTietPhieuXuat
    {
        KetNoiData cn = new KetNoiData();
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * from tblChiTietPhieuXuat " + DieuKien);
        }
        public int ThemDuLieu(EC_tblChiTietPhieuXuat et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO tblChiTietPhieuXuat (MaPX,MaHH,SoLuong,DonGia) 
            VALUES('" + et.MaPX + "', '" + et.MaHH + "'," + et.SoLuong + ", " + et.DonGia + ")");
        }
        public int SuaDuLieu(EC_tblChiTietPhieuXuat et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE tblChiTietPhieuXuat SET MaHH =N'" + et.MaHH + "', SoLuong =" + et.SoLuong + ", DonGia =" + et.DonGia + " where MaPX= '" + et.MaPX + "' and MaHH = '" + et.MaHH + "'");
        }
        public int XoaDuLieu(EC_tblChiTietPhieuXuat et)
        {
            return cn.ThucThiCauLenhSQL(@"DELETE FROM tblChiTietPhieuXuat where MaPX='" + et.MaPX + "' and MaHH = '"+et.MaHH+"'");
        }

        public DataTable getField(string field, string table, string dk)
        {
            return cn.GetDataTable(@"Select distinct " + field + " from " + table + " " + dk);
        }
    }
}
