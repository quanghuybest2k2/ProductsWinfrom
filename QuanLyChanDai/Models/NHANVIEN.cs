using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChanDai.EF;

namespace QuanLyChanDai.Models
{
    public class NHANVIEN
    {
        QuanLyIdolJavEntities db = new QuanLyIdolJavEntities();
        public tb_nhanvien getItem(int id)
        {
            return db.tb_nhanvien.FirstOrDefault(x => x.ID == id); // lay id
        }
        public List<tb_nhanvien> getList()
        {
            return db.tb_nhanvien.ToList(); // lay danh sach nhan vien
        }
        public tb_nhanvien add(tb_nhanvien nv)
        {
            try
            {
                db.tb_nhanvien.Add(nv);
                db.SaveChanges(); // lưu lại trong database
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public tb_nhanvien update(tb_nhanvien nv)
        {
            try
            {
                var _nv = db.tb_nhanvien.FirstOrDefault(x=>x.ID==nv.ID);
                _nv.HOTEN = nv.HOTEN;
                _nv.NGAYSINH = nv.NGAYSINH;
                _nv.GIOITINH = nv.GIOITINH;
                _nv.DIENTHOAI = nv.DIENTHOAI;
                _nv.CCCD = nv.CCCD;
                _nv.DIACHI = nv.DIACHI;
                _nv.HINHANH = nv.HINHANH;
                db.SaveChanges();
                return nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }
        public tb_nhanvien delete(int id)
        {
            try
            {
                var _nv = db.tb_nhanvien.FirstOrDefault(x => x.ID == id);
                db.tb_nhanvien.Remove(_nv);
                db.SaveChanges();
                return _nv;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu: " + ex.Message);
            }
        }

    }
}
