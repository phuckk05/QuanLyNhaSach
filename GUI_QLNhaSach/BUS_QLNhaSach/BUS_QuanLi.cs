using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL_QLNhaSach;
using DTO_QLNhaSach;

namespace BUS_QLNhaSach
{
    public class BUS_QuanLi
    {
        public DBConnect db = new DBConnect();
        DAL_QuanLi dal = new DAL_QuanLi();
        DAL_ThanhToan bill = new DAL_ThanhToan();

        public DataTable getSach()
        {
            return dal.getSach();
        }

        public DataTable getNV()
        {
            return dal.getNV();
        }

        public DataTable getKH()
        {
            return dal.getKH();
        }

        public DataTable getTheLoai()
        {
            return dal.getTheLoai();
        }

        public DataTable getTK()
        {
            return dal.getThongKe();
        }

        public DataTable getTKT()
        {
            return dal.getThongKeTong();
        }
        
        public DataTable getTKNgay(string s)
        {
            return dal.TKNgay(s);
        }

        public DataTable getNXB()
        {
            return dal.getNXB();
        }

        // quan li sach ===========================================================
        public bool themSach(DTO_Sach s)
        {
            return dal.ThemSach(s);
        }

        public bool suaSach(DTO_Sach s)
        {
            return dal.suaSach(s);
        }

        public bool xoaSach(String id)
        {
            return dal.xoaSach(id);
        }

        public DataTable TimKiem(string s)
        {
            return dal.TimKiemSach(s);
        }

        // quan li nha xuat ban =====================================
        public bool themNXB(DTO_NhaXuatBan s)
        {
            return dal.ThemNXB(s);
        }

        public bool suaNXB(DTO_NhaXuatBan s)
        {
            return dal.suaNXB(s);
        }

        public bool xoaNXB(String id)
        {
            return dal.xoaNXB(id);
        }

        // quan li nhan vien =============================================
        public bool themNV(DTO_NhanVien s)
        {
            return dal.ThemNV(s);
        }

        public bool suaNV(DTO_NhanVien s)
        {
            return dal.suaNV(s);
        }

        public bool xoaNV(String id)
        {
            return dal.xoaNV(id);
        }
        // quan li khach hang =============================================
        public bool themKH(DTO_KhachHang s)
        {
            return dal.ThemKH(s);
        }

        public bool suaKH(DTO_KhachHang s)
        {
            return dal.suaKH(s);
        }

        public bool xoaKH(String id)
        {
            return dal.xoaKH(id);
        }
        // chuc nang thanh toan =============================================
       
        public string timkiemNgay(string s)
        {
            return dal.timkiemNgaySinh(s);
        }

        // nap len combox ma nhan vien
        public DataTable idNV ()
        {
            return bill.getMaNV();
        }

        // tim kiem sdt hien ra ten khach hang
        public string timkiemSDT(string s)
        {
            return bill.timkiemSDT(s);
        }

        // tim kiem hien ra ten sach
        public string timkiemMaSach(string s)
        {
            return bill.timkiemMaSach(s);
        }

        // tim kiem hien ra don gia
        public string timkiemMaSach1(string s)
        {
            return bill.timkiemMaSach1(s);
        }

        // tim kiem hien ra ma khach hang
        public string timkiemMaKH(string s)
        {
            return bill.timkiemMaKH(s);
        }

        // tinh tong bill 
        public string tongBill(string s)
        {
            return bill.TongBillBan(s);
        }

        // cap nhat tong tien trong hoa don
        public bool updateBill(DTO_HoaDon s)
        {
            return bill.UpdateTongBill(s);
        }

        // bang hoa đơn chi tiet
        public DataTable getHDCT()
        {
            return bill.getHDCT();
        }

        public bool themHD (DTO_HoaDon s)
        {
            return bill.ThemHD(s);
        }

        public bool themHDCT(DTO_HoaDonChiTiet s)
        {
            return bill.ThemHDCT(s);
        }
    }
}
