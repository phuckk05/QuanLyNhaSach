using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLNhaSach;

namespace DAL_QLNhaSach
{
    public class DAL_QuanLi : DBConnect
    {
        // load len combobox the loai
        public DataTable getTheLoai()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Ten FROM TheLoai", conn);
            DataTable dtTheLoai = new DataTable();
            da.Fill(dtTheLoai);
            return dtTheLoai;
        }

        //load len combobox nxb
        public DataTable getNXB()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM NXB", conn);
            DataTable dtNXB = new DataTable();
            da1.Fill(dtNXB);
            return dtNXB;
        }

        //load data bang nhan vien
        public DataTable getNV()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            DataTable dtNXB = new DataTable();
            da1.Fill(dtNXB);
            return dtNXB;
        }

        //load data bang nhan vien
        public DataTable getKH()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
            DataTable dtNXB = new DataTable();
            da1.Fill(dtNXB);
            return dtNXB;
        }

        // load data bang sach
        public DataTable getSach()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID, TenSach, TacGia, DonGia, TongSoLuong FROM Sach", conn);
            DataTable dtSach = new DataTable();
            da.Fill(dtSach);
            return dtSach;
        }

        // tìm kiem sach theo ma
        public DataTable TimKiemSach(string s)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID, TenSach, TacGia, DonGia, TongSoLuong FROM Sach where ID = '" + s + "'", conn);
            DataTable Sach = new DataTable();
            da.Fill(Sach);
            return Sach;
        }

        // load data thong ke
        public DataTable getThongKe()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
            DataTable dtTK = new DataTable();
            da.Fill(dtTK);
            return dtTK;
        }

        public DataTable TKNgay(string s)
        {
            string sql = "select a.ID, a.NgayLap , a.ThanhTien from HoaDon a where a.NgayLap = '"+ s +"' AND cast(a.ThanhTien as int) != 0";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtTKNgay = new DataTable();
            da.Fill(dtTKNgay);
            return dtTKNgay;
        }

        public DataTable getThongKeTong()
        {
            string sql = "select a.MaHD, COUNT(a.ID), sum(cast(a.ThanhTien as int)) from HoaDonChiTiet a Group by a.MaHD";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dtTKT = new DataTable();
            da.Fill(dtTKT);
            return dtTKT;
        }

        // them thong tin sach
        public bool ThemSach(DTO_Sach s)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("INSERT INTO Sach(ID, TenSach, TacGia, DonGia, TongSoLuong, TheLoaiID, NXBID) VALUES('{0}', N'{1}', N'{2}', '{3}', '{4}','{5}','{6}')"
                    , s.IDSach1, s.TenSach1, s.TacGia1, s.DonGia1, s.TongSL1, s.TheLoaiId1, s.NXBId1);
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

        // sua thong tin sach
        public bool suaSach(DTO_Sach s)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE Sach SET TenSach = N'{0}' , DonGia = '{1}', TongSoLuong = '{2}' WHERE ID = '{3}' "
                    , s.TenSach1, s.DonGia1, s.TongSL1, s.IDSach1);
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

        // xoa sach
        public bool xoaSach(string id_sach)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM Sach WHERE ID = '{0}' ", id_sach);

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
                conn.Close();
            }
            return false;
        }

        // them thong tin nhà xuat ban
        public bool ThemNXB(DTO_NhaXuatBan s)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("INSERT INTO NXB(TenNXB, DiaChi, Email, SDT) VALUES(N'{0}', N'{1}', N'{2}', '{3}')"
                    , s.TenNXB1, s.DiaChi1, s.Email1, s.SDT1);
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

        // xoa nha xuat ban
        public bool xoaNXB(string id)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM NXB WHERE SDT = '{0}' ", id);

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
                conn.Close();
            }
            return false;
        }

        // sua thong tin nha xuat ban
        public bool suaNXB(DTO_NhaXuatBan s)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE NXB SET DiaChi = N'{0}' , Email = N'{1}' WHERE SDT = '{2}' "
                    , s.DiaChi1, s.Email1, s.SDT1);
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

        // them thong tin nhan vien
        public bool ThemNV(DTO_NhanVien s)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("INSERT INTO NhanVien(ID, TenNV, NgaySinh, GioiTinh, CCCD, DiaChi, SDT) " +
                    "VALUES('{0}', N'{1}', '{2}', N'{3}', '{4}', N'{5}', '{6}')"
                    , s.ID1, s.TenNV1, s.NgaySinh1, s.GT1, s.CCCD1, s.DiaChi1, s.SDT1);
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

        // xoa nhan vien
        public bool xoaNV(string id)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM NhanVien WHERE ID = '{0}' ", id);

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
                conn.Close();
            }
            return false;
        }

        // sua thong tin nhan vien
        public bool suaNV(DTO_NhanVien s)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE NhanVien SET TenNV = N'{0}' , NgaySinh = '{1}' , GioiTinh = N'{2}' ,CCCD = '{3}' , DiaChi = N'{4}', SDT = '{5}' WHERE ID = '{6}' "
                    , s.TenNV1, s.NgaySinh1,s.GT1, s.CCCD1, s.DiaChi1, s.SDT1, s.ID1);
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

        // them thong tin khach hang
        public bool ThemKH(DTO_KhachHang s)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("INSERT INTO KhachHang(ID, TenKH, NgaySinh, GioiTinh, CCCD, SDT) " +
                    "VALUES('{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}')"
                    , s.ID1, s.TenKH1, s.NgaySinh1, s.GT1, s.CCCD1, s.SDT1);
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

        // xoa khach hang
        public bool xoaKH(string id)
        {
            try
            {
                // Ket noi
                conn.Open();
                string SQL = string.Format("DELETE FROM KhachHang WHERE ID = '{0}' ", id);

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
                conn.Close();
            }
            return false;
        }

        // sua thong tin khach hang
        public bool suaKH(DTO_KhachHang s)
        {
            try
            {
                // Ket noi
                conn.Open();
                // Query string
                string SQL = string.Format("UPDATE KhachHang SET TenKH = N'{0}' , NgaySinh = '{1}' , CCCD = '{2}' ,  SDT = '{3}' WHERE ID = '{4}' "
                    , s.TenKH1, s.NgaySinh1, s.CCCD1, s.SDT1, s.ID1);
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

        public string timkiemNgaySinh(string s)
        {
            string sql;
            sql = "Select NgaySinh from NhanVien where ID = '" + s + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            string x = (string)cmd.ExecuteScalar();
            conn.Close();
            return x;
        }


    }
}
