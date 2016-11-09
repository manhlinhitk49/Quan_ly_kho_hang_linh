using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangBUS
{
    public class BUS_tblPhieuxuat
    {
        SQL_tblPhieuXuat sql = new SQL_tblPhieuXuat();
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public int ThemDuLieu(EC_tblPhieuXuat et)
        {
            return sql.ThemDuLieu(et);
        }
        public int SuaDuLieu(EC_tblPhieuXuat et)
        {
            return sql.SuaDuLieu(et);
        }
        public int XoaDuLieu(EC_tblPhieuXuat et)
        {
            return sql.XoaDuLieu(et);
        }
        public DataTable getField(string field)
        {
            return sql.getField(field,"tblPhieuxuat", "");
        }
        public DataTable getField(string field, string dk)
        {
            return sql.getField(field, "tblPhieuxuat", dk);
        }
        public DataTable getField(string field, string table, string dk)
        {
            return sql.getField(field, table, dk);
        }
        
    }
}
