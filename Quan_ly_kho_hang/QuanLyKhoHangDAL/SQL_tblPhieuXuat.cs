using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangDAL
{
    public class SQL_tblPhieuXuat
    {
        KetNoiData cn = new KetNoiData();
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * from tblPhieuXuat " + DieuKien);
        }
        public int ThemDuLieu(EC_tblPhieuXuat et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO tblPhieuXuat (MaPX,MaCN,NgayXuat,TongTien) 
            VALUES('" + et.MaPX + "', '" + et.MaCN + "','" + et.NgayXuat + "', " + et.TongTien + ")");
        }
        public int SuaDuLieu(EC_tblPhieuXuat et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE tblPhieuXuat SET MaCN =N'" + et.MaCN + "', NgayXuat ='" + et.NgayXuat+ "', TongTien ='" + et.TongTien + "' where MaPX= '" + et.MaPX + "'");
        }
        public int XoaDuLieu(EC_tblPhieuXuat et)
        {
            return cn.ThucThiCauLenhSQL(@"DELETE FROM tblPhieuXuat where MaPX=N'" + et.MaPX + "'");
        }

        public DataTable getField(string field,string table, string dk)
        {
            return cn.GetDataTable(@"Select distinct "+field+" from "+table+" " + dk);
        }

       
    }
}
