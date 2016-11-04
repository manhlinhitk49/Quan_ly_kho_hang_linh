using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangBUS
{
    public class BUS_tblChiTietPhieuXuat
    {
        SQL_tblChiTietPhieuXuat sql = new SQL_tblChiTietPhieuXuat();
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public int ThemDuLieu(EC_tblChiTietPhieuXuat et)
        {
            return sql.ThemDuLieu(et);
        }
        public int SuaDuLieu(EC_tblChiTietPhieuXuat et)
        {
            return sql.SuaDuLieu(et);
        }
        public int XoaDuLieu(EC_tblChiTietPhieuXuat et)
        {
            return sql.XoaDuLieu(et);
        }
        public DataTable getField(string field)
        {
            return sql.getField(field, "tblChiTietPhieuXuat", "");
        }
        public DataTable getField(string field, string dk)
        {
            return sql.getField(field, "tblChiTietPhieuXuat", dk);
        }
        public DataTable getField(string field, string table, string dk)
        {
            return sql.getField(field, table, dk);
        }
    }
}
