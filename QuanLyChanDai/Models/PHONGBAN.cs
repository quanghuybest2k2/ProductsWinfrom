using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyChanDai.EF;

namespace QuanLyChanDai.Models
{
    public class PHONGBAN
    {
        QuanLyIdolJavEntities db = new QuanLyIdolJavEntities();
        public List<tb_PHONGBAN> getList()
        {
            return db.tb_PHONGBAN.ToList();
        }
    }
}
