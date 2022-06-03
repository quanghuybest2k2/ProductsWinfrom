using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        private string _MaKhoa;

        public string MaKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }
        private string _MaLop;

        public string MaLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }
        private string _TenLop;

        public string TenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }
        public Lop(string pMaKhoa, string pMaLop, string pTenLop)
        {
            this._MaKhoa = pMaKhoa;
            this._MaLop = pMaLop;
            this._TenLop = pTenLop;
        }
    }
}
