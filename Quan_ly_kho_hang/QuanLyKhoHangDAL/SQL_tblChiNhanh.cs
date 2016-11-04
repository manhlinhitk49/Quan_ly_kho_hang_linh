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
        public DataTable TaoBang(string dk)
        {
            return cn.GetDataTable("SELECT * from tblChiNhanh " + dk);
        }
        public int ThemDuLieu(EC_tblChiNhanh et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO tblChiNhanh (MaCN, TenCN, DiaChi, SDT) 
            VALUES(N'" + et.MaCN + "',N'" + et.TenCN + "',N'" + et.DiaChi + "',N'" + et.SDT + "')");
        }
        public int SuaDuLieu(EC_tblChiNhanh et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE tblChiNhanh SET TenCN =N'" + et.TenCN + "', DiaChi =N'" + et.DiaChi + "', SDT =N'" + et.SDT + "'WHERE MaCN = '"+ et.MaCN + "'");
        }
        public string XoaDuLieu(EC_tblChiNhanh et)
        {
            return cn.ThucThiCauLenhSQL_CoThongBao(@"DELETE FROM tblChiNhanh where MaCN=N'" + et.MaCN + "'");
        }

        public int TimKiem(string chuoitimkiem)
        {
            return cn.ThucThiCauLenhSQL(chuoitimkiem);
        }
    }
}
