using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaSach
{
    public class DTO_HoaDonChiTiet
    {
        private int ID;
        private string MaSach;
        private int SL;
        private string ThanhTien;
        private string MaHD;
        //============================================================================

        public int ID1 { get => ID; set => ID = value; }
        public string MaSach1 { get => MaSach; set => MaSach = value; }
        public int SL1 { get => SL; set => SL = value; }
        public string ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        public string MaHD1 { get => MaHD; set => MaHD = value; }

        //============================================================================

        public DTO_HoaDonChiTiet( string masach, int sl, string thanhtien, string mahd)
        {
            this.MaSach = masach;
            this.SL = sl;
            this.ThanhTien = thanhtien;
            this.MaHD = mahd;
        }
    }
}
