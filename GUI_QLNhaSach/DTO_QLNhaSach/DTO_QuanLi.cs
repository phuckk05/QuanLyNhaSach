using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaSach
{
    public class DTO_QuanLi
    {
        private string TenTheLoai;
        private string TenNXB;
      
        private int IDSach;
        private string TenSach;
        private int DonGia;
        private int TongSL;
        private int TheLoaiId;
        private int NXBId;
        /**********************************************/
        public string TenTheLoai1 { get => TenTheLoai; set => TenTheLoai = value; }
        public string TenNXB1 { get => TenNXB; set => TenNXB = value; }
        public int IDSach1 { get => IDSach; set => IDSach = value; }
        public string TenSach1 { get => TenSach; set => TenSach = value; }
        public int DonGia1 { get => DonGia; set => DonGia = value; }
        public int TongSL1 { get => TongSL; set => TongSL = value; }
        public int TheLoaiId1 { get => TheLoaiId; set => TheLoaiId = value; }
        public int NXBId1 { get => NXBId; set => NXBId = value; }
    }
}
