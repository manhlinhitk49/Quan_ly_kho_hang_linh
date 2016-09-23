using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;


namespace QuanLyKhoHangBUS
{
    public class BUS_tblDangNhap
    {
        SQL_tblDangNhap sql = new SQL_tblDangNhap();
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
