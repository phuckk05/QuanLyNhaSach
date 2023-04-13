using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLNhaSach;

namespace BUS_QLNhaSach
{
    public class BUS_QuanLi
    {
        DAL_QuanLi dal = new DAL_QuanLi();

        public DataTable getTheLoai()
        {
            return dal.getTheLoai();
        }

        public DataTable getNXB()
        {
            return dal.getNXB();
        }
    }
}
