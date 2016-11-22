using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangBUS
{
    public class BUS_tblNhaCungCap
    {
        SQL_tblNhaCungCap sql = new SQL_tblNhaCungCap();
        public DataTable getAllNhaCungCap()
        {
            return sql.getAllNhaCungCap();
        }
        public DataTable getNhaCungCap(string dk)
        {
            return sql.getNhaCungCap(dk);
        }
        public int ThemDuLieu(EC_tblNhaCungCap et)
        {
            return sql.ThemDuLieu(et);
        }
        public int SuaDuLieu(EC_tblNhaCungCap et)
        {
            return sql.SuaDuLieu(et);
        }
        public int XoaDuLieu(EC_tblNhaCungCap et)
        {
            return sql.XoaDuLieu(et);
        }
        public DataTable LayRaMaNCC()
        {
            return sql.LayRaMaNCC();
        }
    }
}
