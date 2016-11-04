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
        public DataTable TaoBang(string dk)
        {
            return sql.TaoBang(dk);
        }
        public int ThemDuLieu(EC_tblChiNhanh et)
        {
            return sql.ThemDuLieu(et);
        }
        public int SuaDuLieu(EC_tblChiNhanh et)
        {
            return sql.SuaDuLieu(et);
        }
        public string XoaDuLieu(EC_tblChiNhanh et)
        {
            return sql.XoaDuLieu(et);
        }
    }
}
