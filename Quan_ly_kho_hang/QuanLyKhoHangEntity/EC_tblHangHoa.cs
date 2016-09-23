using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKhoHangEntity
{
    public class EC_tblHangHoa
    {
        private string _MaHH;

        public string MaHH
        {
            get { return _MaHH; }
            set { _MaHH = value; }
        }
        private string _TenHH;

        public string TenHH
        {
            get { return _TenHH; }
            set { _TenHH = value; }
        }
        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        private float _GiaNhap;

        public float GiaNhap
        {
            get { return _GiaNhap; }
            set { _GiaNhap = value; }
        }
        private float _GiaXuat;

        public float GiaXuat
        {
            get { return _GiaXuat; }
            set { _GiaXuat = value; }
        }
        private string _NSX;

        public string NSX
        {
            get { return _NSX; }
            set { _NSX = value; }
        }
        private string _ThongTin;

        public string ThongTin
        {
            get { return _ThongTin; }
            set { _ThongTin = value; }
        }
    }
}
