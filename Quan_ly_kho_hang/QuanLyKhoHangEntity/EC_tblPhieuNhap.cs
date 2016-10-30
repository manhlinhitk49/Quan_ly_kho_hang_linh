using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKhoHangEntity
{
    public class EC_tblPhieuNhap
    {
        private string _MaPN;

        public string MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }
        private string _MaNCC;

        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        private string _NgayNhap;

        public string NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
        private int _TongTien;

        public int TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
    }
}
