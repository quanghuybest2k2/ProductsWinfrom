using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        protected SqlConnection _cn = new SqlConnection(@"Data Source=DESKTOP-QDTENRH\SQLEXPRESS;Initial Catalog=QuanLyLopHoc;Integrated Security=True");
        
    }
}
