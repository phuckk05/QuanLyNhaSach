using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNhaSach;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLNhaSach
{
    public class DAL_ThanhToan : DBConnect
    {
        // nap combox ma nhan vien
        public DataTable getMaNV()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID FROM NhanVien", conn);
            DataTable idNV = new DataTable();
            da.Fill(idNV);
            return idNV;
        }


        //load data bang hoa don chi tiet
        public DataTable getHDCT()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM HoaDonChiTiet", conn);
            DataTable dtHDCT = new DataTable();
            da1.Fill(dtHDCT);
            return dtHDCT;
        }

        public bool ThemHD(DTO_HoaDon s)
        {
            try
            {
                // Ket noi
                conn.Open();
                string sql = string.Format("INSERT INTO HoaDon(ID, NgayLap, MaNV, MaKH, Thanhtien) VALUES('{0}', '{1}', '{2}', '{3}', '{4}') ",
                    s.ID1, s.NgayLap1, s.MaNV1, s.MaKH1, s.TongTien1);
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

        public bool ThemHDCT(DTO_HoaDonChiTiet s)
        {
            try
            {
                conn.Open();
                string sql = string.Format("INSERT INTO HoaDonChiTiet(MaSach, SL, ThanhTien, MaHD) VALUES('{0}', '{1}', '{2}', '{3}') ",
                    s.MaSach1, s.SL1, s.ThanhTien1, s.MaHD1);
                SqlCommand cmd = new SqlCommand(sql, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

        public bool UpdateTongBill (DTO_HoaDon s)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE HoaDon SET ThanhTien = '{0}'  WHERE ID = '{1}' "
                    , s.TongTien1, s.ID1);
                SqlCommand cmd = new SqlCommand(SQL, conn);
                // Query và kiểm tra
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception e)
            {
            }
            finally
            {
                // Dong ket noi
                conn.Close();
            }
            return false;
        }

        public string TongBillBan(string s)
        {
            string sql;
            sql = "select sum(cast(a.ThanhTien as int)) as Tong from HoaDonChiTiet a where a.MaHD = '" + s + "' group by a.MaHD";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            string k = (string)cmd.ExecuteScalar().ToString();
            conn.Close();
            return k;
        }

        // tim kiem sdt hien ra ten khach hang
        public string timkiemSDT(string s)
        {
            string sql;
            sql = "Select TenKH from KhachHang where SDT = '" + s + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            string k = (string)cmd.ExecuteScalar();
            conn.Close();
            return k;
        }

        // tim kiem ma sach hien ten sach
        public string timkiemMaSach(string s)
        {
            string sql;
            sql = "Select TenSach from Sach where ID = '" + s + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            string k = (string)cmd.ExecuteScalar();
            conn.Close();
            return k;
        }

        // tim kiem ma sach hien don gia
        public string timkiemMaSach1(string s)
        {
            string sql;
            sql = "Select DonGia from Sach where ID = '" + s + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            string x = (string)cmd.ExecuteScalar();
            conn.Close();
            return x;
        }

        // tim kiem ma sach hien ma khach hang
        public string timkiemMaKH(string s)
        {
            string sql;
            sql = "Select ID from KhachHang where SDT = '" + s + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            string x = (string)cmd.ExecuteScalar();
            conn.Close();
            return x;
        }

    }
}
