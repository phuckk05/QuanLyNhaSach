using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QLNhaSach
{
    // quan li sach
    public class DTO_Sach
    {
        private string TenTheLoai;
        private string TenNXB;
      
        private string IDSach;
        private string TenSach;
        private string TacGia;
        private int DonGia;
        private int TongSL;
        private int TheLoaiId;
        private int NXBId;
        /**********************************************/
        public string TenTheLoai1 { get => TenTheLoai; set => TenTheLoai = value; }
        public string TenNXB1 { get => TenNXB; set => TenNXB = value; }       
        public string TenSach1 { get => TenSach; set => TenSach = value; }
        public int DonGia1 { get => DonGia; set => DonGia = value; }
        public int TongSL1 { get => TongSL; set => TongSL = value; }
        public int TheLoaiId1 { get => TheLoaiId; set => TheLoaiId = value; }
        public int NXBId1 { get => NXBId; set => NXBId = value; }
        public string IDSach1 { get => IDSach; set => IDSach = value; }
        public string TacGia1 { get => TacGia; set => TacGia = value; }

        /********************************************/
        public DTO_Sach()
        {

        }

        public DTO_Sach(String id, string Ten, int dongia, int sl)
        {
            this.IDSach = id;
            this.TenSach = Ten;
            this.DonGia = dongia;
            this.TongSL = sl;
        }

        public DTO_Sach(String id, string Ten , string tg, int dongia, int sl, int theloaiid, int nxbid)
        {
            this.IDSach = id;
            this.TenSach = Ten;
            this.TacGia = tg;
            this.DonGia = dongia;
            this.TongSL = sl;
            this.TheLoaiId = theloaiid;
            this.NXBId = nxbid;
        }
    }
}
