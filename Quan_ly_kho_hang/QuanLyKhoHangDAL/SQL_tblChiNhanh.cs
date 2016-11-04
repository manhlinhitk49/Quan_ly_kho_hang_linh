using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyKhoHangEntity;
using System.Data;

namespace QuanLyKhoHangDAL
{
    public class SQL_tblChiNhanh
    {
        KetNoiData cn = new KetNoiData();
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("SELECT * from tblChiNhanh " + DieuKien);
        }
        public int ThemDuLieu(EC_tblChiNhanh et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO tblChiNhanh (MaCN,TenCN,DiaChi,SDT) 
            VALUES('" + et.MaCN + "', N'" + et.TenCN + "',N'" + et.DiaChi + "', " + et.SDT + ")");
        }
        public int SuaDuLieu(EC_tblChiNhanh et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE tblChiNhanh SET TenCN =N'" + et.MaCN + "', DiaChi =N'" + et.DiaChi + "', SDT ='" + et.SDT + "' where MaNC= '" + et.MaCN + "'");
        }
        public int XoaDuLieu(EC_tblChiNhanh et)
        {
            return cn.ThucThiCauLenhSQL(@"DELETE FROM tblChiNhanh where MaCN=N'" + et.MaCN + "'");
        }

        public DataTable getField(string field, string table, string dk)
        {
            return cn.GetDataTable(@"Select distinct " + field + " from " + table + " " + dk);
        }
    }
}
