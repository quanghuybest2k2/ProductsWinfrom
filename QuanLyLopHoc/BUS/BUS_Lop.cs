using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_Lop
    {
        DAL_Lop dal_lop = new DAL_Lop();
        public bool Insert(Lop plop)
        {
            return dal_lop.Insert(plop);
        }
        public bool Delete(string pMa)
        {
            return dal_lop.Delete(pMa);
        }
        public bool Update(Lop plop)
        {
            return dal_lop.Update(plop);
        }
        public DataTable Get_Khoa()
        {
            return dal_lop.Get_Khoa();
        }
    }
}
