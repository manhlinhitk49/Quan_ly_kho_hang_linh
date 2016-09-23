using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyKhoHangEntity
{
    public class EC_tblNhaCungCap
    {
        private string _MaNCC;

        public string MaNCC
        {
            get { return _MaNCC; }
            set { _MaNCC = value; }
        }
        private string _TenNCC;

        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }
        private string _DicChi;

        public string DicChi
        {
            get { return _DicChi; }
            set { _DicChi = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
    }
}
