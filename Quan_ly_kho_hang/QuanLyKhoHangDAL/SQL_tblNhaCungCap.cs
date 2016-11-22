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
        public int ThemDuLieu(EC_tblNhaCungCap et)
        {
            return cn.ThucThiCauLenhSQL(@"INSERT INTO tblNhaCungCap (MaNCC,TenNCC,DiaChi,SDT) 
            VALUES('" + et.MaNCC + "', N'" + et.TenNCC + "',N'" + et.DiaChi + "', " + et.SDT + ")");
        }
        public int SuaDuLieu(EC_tblNhaCungCap et)
        {
            return cn.ThucThiCauLenhSQL(@"UPDATE tblNhaCungCap SET TenNCC =N'" + et.TenNCC + "', DiaChi =N'" + et.DiaChi + "', SDT ='" + et.SDT + "' where MaNCC= '" + et.MaNCC + "'");
        }
        public int XoaDuLieu(EC_tblNhaCungCap et)
        {
            return cn.ThucThiCauLenhSQL(@"DELETE FROM tblNhaCungCap where MaNCC=N'" + et.MaNCC + "'");
        }
        public DataTable LayRaMaNCC()//lấy ra top 1 mã thiết bị có tên mã thiết bị là gì đó
        {
            return cn.GetDataTable("select top 1  MaNCC from tblNhaCungCap order by MaNCC desc ");
        }
    }
}
