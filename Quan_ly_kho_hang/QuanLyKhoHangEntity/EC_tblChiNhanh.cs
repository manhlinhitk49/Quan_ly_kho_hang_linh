using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKhoHangEntity
{
    public class EC_tblChiNhanh
    {
        private string _MaCN;

        public string MaCN
        {
            get { return _MaCN; }
            set { _MaCN = value; }
        }
        private string _TenCN;

        public string TenCN
        {
            get { return _TenCN; }
            set { _TenCN = value; }
        }
        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
    }
}
