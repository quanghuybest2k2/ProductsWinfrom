using System;
using System.Collections.Generic;
using System.Text;

namespace Tao_Foms_v2
{
    class NguoiDung
    {
        private string taiKhoan, matKhau;
        public NguoiDung()
        {
            taiKhoan = matKhau = "";
        }
        public NguoiDung(string tk, string mk)
        {
            taiKhoan = tk;
            matKhau = mk;
        }
        public int KiemTraDangNhap(string taiKhoanGoc, string matKhauGoc)
        {
            if (taiKhoan == taiKhoanGoc && matKhau == matKhauGoc)
            {
                return 1; // hợp lệ
            }
            return 0; // không hợp lệ
        }

    }
}
