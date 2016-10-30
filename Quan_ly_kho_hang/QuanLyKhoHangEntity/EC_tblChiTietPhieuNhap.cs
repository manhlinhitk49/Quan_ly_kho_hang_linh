using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKhoHangEntity
{
    public class EC_tblChiTietPhieuNhap
    {
        private string _MaPN;

        public string MaPN
        {
            get { return _MaPN; }
            set { _MaPN = value; }
        }
        private string _MaHH;

        public string MaHH
        {
            get { return _MaHH; }
            set { _MaHH = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private int _DonGia;

        public int DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        private int _ThanhTien;

        public int ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }
    }
}
