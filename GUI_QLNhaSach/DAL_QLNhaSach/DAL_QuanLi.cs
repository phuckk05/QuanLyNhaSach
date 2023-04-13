using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLNhaSach
{
    public class DAL_QuanLi : DBConnect
    {
        public DataTable getTheLoai()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Ten FROM TheLoai", _conn);
            DataTable dtTheLoai = new DataTable();
            da.Fill(dtTheLoai);
            return dtTheLoai;
        }

        public DataTable getNXB()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT TenNXB FROM NXB", _conn);
            DataTable dtNXB = new DataTable();
            da1.Fill(dtNXB);
            return dtNXB;
        }
    }
}
