using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKhoHangEntity
{
    public class EC_tblPhieuXuat
    {
        private string _MaPX;

        public string MaPX
        {
            get { return _MaPX; }
            set { _MaPX = value; }
        }
        private string _MaCN;

        public string MaCN
        {
            get { return _MaCN; }
            set { _MaCN = value; }
        }
        private string _NgayXuat;

        public string NgayXuat
        {
            get { return _NgayXuat; }
            set { _NgayXuat = value; }
        }
        private float _TongTien;

        public float TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
    }
}
