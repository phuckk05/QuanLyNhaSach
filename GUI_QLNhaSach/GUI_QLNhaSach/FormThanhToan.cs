using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLNhaSach;
using DTO_QLNhaSach;

namespace GUI_QLNhaSach
{
    public partial class FormThanhToan : Form
    {
        BUS_QuanLi busql = new BUS_QuanLi();
        public FormThanhToan()
        {
            InitializeComponent();
            loadMaNV();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            databill.DataSource = busql.getHDCT();
            databill.AllowUserToAddRows = false;
            databill.EditMode = DataGridViewEditMode.EditProgrammatically;

            databill.Columns[0].Visible = false;
            HeaderText();
            SizeText();
            TaoSo();
        }

        // nap ma nhan vien len combox
        private void loadMaNV()
        {
            cbMaNV.DataSource = busql.idNV();
            cbMaNV.DisplayMember = "ID";
        }

        // chinh tieu de cot trong data sach
        private void HeaderText()
        {
            this.databill.Columns[0].HeaderText = "STT";
            this.databill.Columns[1].HeaderText = "Mã sách";
            this.databill.Columns[2].HeaderText = "Số lượng";
            this.databill.Columns[3].HeaderText = "Thành tiền";
            this.databill.Columns[4].HeaderText = "Mã hóa đơn";
        }

        // chinh kich thuoc cot trong data sach
        private void SizeText()
        {
            this.databill.Columns[0].Width = 100;
            this.databill.Columns[1].Width = 220;
            this.databill.Columns[2].Width = 150;
            this.databill.Columns[3].Width = 212;
            this.databill.Columns[4].Width = 150;
        }

        // tao ra ma hoa don ngau nhien
        private void TaoSo()
        {
            string s = "HD";
            Random random = new Random();
            List<int> numbers = new List<int>();
            int dem = random.Next(10000, 99999);
            if (!numbers.Contains(dem))
            {
                numbers.Add(dem);
                string so = dem.ToString();
                txtMaHD.Text = "HD" + dem;
            }
        }

        private void txtMaSach_TextChanged(object sender, EventArgs e)
        {
            txtTenSach.Text = busql.timkiemMaSach(txtMaSach.Text);
            string s = txtDonGia.Text = busql.timkiemMaSach1(txtMaSach.Text);
            int sl = Convert.ToInt32(txtSL.Text);
            int gia = Convert.ToInt32(s);
            int tong = gia * sl;
            txtThanhTien.Text = tong.ToString();
        }

        // them san pham vao hoa don chi tiet
        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text != "" && txtSL.Text != "")
            {
                int sl = Convert.ToInt32(txtSL.Text);
                DTO_HoaDonChiTiet tv = new DTO_HoaDonChiTiet(txtMaSach.Text, sl, txtThanhTien.Text, txtMaHD.Text);
                
                if (busql.themHDCT(tv))
                {
                    MessageBox.Show("Thêm thông tin sách thành công !!!", "Thông báo");
                    databill.DataSource = busql.getHDCT();
                    txtTongTien.Text = busql.tongBill(txtMaHD.Text);
                    resetHDCT();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin sách không thành công !!!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập thông tin đầy đủ!!!", "Thông báo");
            }           
        }

        // update tong tien hoa don
        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "")
            {
                DTO_HoaDon tv = new DTO_HoaDon(txtMaHD.Text, txtTongTien.Text);

                if (busql.updateBill(tv))
                {
                    MessageBox.Show("Thêm thông tin hóa đơn thành công !!!", "Thông báo");
                    databill.DataSource = busql.getHDCT();
                    resetHD();
                    TaoSo();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin hóa đơn không thành công !!!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập thông tin hóa đơn đầy đủ!!!", "Thông báo");
            }
        }

        // reset gia tri hoa don
        private void resetHD()
        {
            txtSDT.Text = "";
            cbMaNV.Text = "";
            txtMaHD.Text = "";
            resetHDCT();
        }

        // reset gia tri hoa don chi tiet
        private void resetHDCT()
        {
            txtMaSach.Text = "";
            txtSL.Text = "";
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            txtTenKH.Text = busql.timkiemSDT(txtSDT.Text);
            txtMaKH.Text = busql.timkiemMaKH(txtSDT.Text);
        }

        // luu thong tin hoa don vs tong tien = 0
        private void btLuuTam_Click(object sender, EventArgs e)
        {
            if (txtNgay.Text != "" && txtSDT.Text != "" && txtMaHD.Text != "")
            {

                DTO_HoaDon tv = new DTO_HoaDon(txtMaHD.Text, txtNgay.Text, cbMaNV.Text, txtMaKH.Text, "0");
                if (busql.themHD(tv))
                {
                    MessageBox.Show("Thêm thông tin thành công !!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thông tin không thành công !!!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập thông tin đầy đủ!!!", "Thông báo");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
