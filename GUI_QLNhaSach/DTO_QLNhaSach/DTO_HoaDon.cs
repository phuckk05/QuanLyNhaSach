using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaSach
{
    public class DTO_HoaDon
    {
        private string ID;
        private string NgayLap;
        private string MaKH;
        private string MaNV;
        private string TongTien;

        //=================================================================================
        public string ID1 { get => ID; set => ID = value; }
        public string NgayLap1 { get => NgayLap; set => NgayLap = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string TongTien1 { get => TongTien; set => TongTien = value; }

        //=================================================================================

        public DTO_HoaDon(string id, string tong)
        {
            this.ID = id;
            this.TongTien = tong;
        }

        public DTO_HoaDon (string ngay, string Manv, string makh, string Tong)
        {
            this.NgayLap = ngay;
            this.MaNV = Manv;
            this.MaKH = makh;
            this.TongTien = Tong;
        }

        public DTO_HoaDon(string id, string ngay, string Manv, string makh, string Tong )
        {
            this.ID = id;
            this.NgayLap = ngay;
            this.MaNV = Manv;
            this.MaKH = makh;
            this.TongTien = Tong;
        }
    }
}
