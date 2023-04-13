using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL_QLNhaSach
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source = DESKTOP-O14SFF4; Initial Catalog = QuanLyNhaSach; Integrated Security = True");
    }
}
