using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
    public class DAL_Lop:DBConnect
    {
        // class này xử lý các table trong db
        // kế thừa lại class DbConnect để có Sql Connection
        public DataTable Get_Khoa()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KHOA", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable Get()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOP", _cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch
            {

                return null;
            }
        }
        DataTable dt = new DataTable();
        public DAL_Lop()
        {
            dt = Get();
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        // them
        public bool Insert(Lop plop)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOP", _cn);
                DataRow r = dt.NewRow();
                r["MaKhoa"] = plop.MaKhoa;
                r["MaLop"] = plop.MaLop;
                r["TenLop"] = plop.TenLop;
                dt.Rows.Add(r);
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(string pMa)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOP", _cn);
                DataRow r = dt.Rows.Find(pMa);
                if (r!=null)
                {
                    r.Delete();
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Update(Lop pLop)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LOP", _cn);
                DataRow r = dt.Rows.Find(pLop.MaLop);
                if (r != null)
                {
                    r["TenLop"] = pLop.TenLop;
                    r["MaKhoa"] = pLop.MaKhoa;
                }
                SqlCommandBuilder cm = new SqlCommandBuilder(da);
                da.Update(dt);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
