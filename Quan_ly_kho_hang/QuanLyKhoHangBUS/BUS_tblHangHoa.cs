using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangDAL;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangBUS
{
    public class BUS_tblHangHoa
    {
        SQL_tblHangHoa sql = new SQL_tblHangHoa();
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
        public int ThemDuLieu(EC_tblHangHoa et)
        {
            return sql.ThemDuLieu(et);
        }
        public int SuaDuLieu(EC_tblHangHoa et)
        {
            return sql.SuaDuLieu(et);
        }
        public int XoaDuLieu(EC_tblHangHoa et)
        {
            return sql.XoaDuLieu(et);
        }
        public DataTable getHH(string dk)
        {
            return sql.getHH(dk);
        }
        public int SuaSoLuong(EC_tblHangHoa et)
        {
            return sql.SuaSoLuong(et);
        }
        public DataTable getHistory(string dk)
        {
            return sql.getHistory(dk);
        }
    }
}
