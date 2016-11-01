using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyKhoHangEntity;
namespace QuanLyKhoHangDAL
{
    public class SQL_tblNhaCungCap
    {
        KetNoiData cn = new KetNoiData();
        public DataTable getAllNhaCungCap()
        {
            return cn.GetDataTable(@"SELECT * from tblNhaCungCap");
        }
        public DataTable getNhaCungCap(string dk)
        {
            return cn.GetDataTable(@"SELECT * from tblNhaCungCap "+ dk);
        }
    }
}
