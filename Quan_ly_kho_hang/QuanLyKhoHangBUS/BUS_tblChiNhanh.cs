using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;


namespace QuanLyKhoHangBUS
{
    public class BUS_tblChiNhanh
    {
        SQL_tblChiNhanh sql = new SQL_tblChiNhanh();
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public int ThemDuLieu(EC_tblChiNhanh et)
        {
            return sql.ThemDuLieu(et);
        }
        public int SuaDuLieu(EC_tblChiNhanh et)
        {
            return sql.SuaDuLieu(et);
        }
        public int XoaDuLieu(EC_tblChiNhanh et)
        {
            return sql.XoaDuLieu(et);
        }
        public DataTable getField(string field)
        {
            return sql.getField(field, "tblChiNhanh", "");
        }
        public DataTable getField(string field, string dk)
        {
            return sql.getField(field, "tblChiNhanh", dk);
        }
        public DataTable getField(string field, string table, string dk)
        {
            return sql.getField(field, table, dk);
        }
    }
}
