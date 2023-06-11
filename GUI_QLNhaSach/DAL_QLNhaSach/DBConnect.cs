using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL_QLNhaSach
{
    public class DBConnect
    {
        public SqlConnection conn = new SqlConnection("Data Source = DESKTOP-O14SFF4; Initial Catalog = QuanLyNhaSach; Integrated Security = True");
    }
}
