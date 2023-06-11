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
    public partial class FormDangKy : Form
    {
        BUS_QuanLi busql = new BUS_QuanLi();
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" && txtNgaySinh.Text != "" && txtCCCD.Text != "" && txtSDT.Text != "" )
            {
                DTO_KhachHang tv = new DTO_KhachHang(txtMaKH.Text ,txtTenKH.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtSDT.Text);

                if (busql.themKH(tv))
                {
                    MessageBox.Show("Thêm thông tin khách hàng thành công !!!", "Thông báo");
                    reset();
                    taoMaKH();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin khách hàng không thành công !!!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập thông tin khách hàng đầy đủ!!!", "Thông báo");
            }
        }

        private void reset()
        {
            txtTenKH.Text = "";
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            cbGT.Text = "";
        }

        private void taoMaKH()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            int dem = random.Next(100, 999);
            if (!numbers.Contains(dem))
            {
                numbers.Add(dem);
                string so = dem.ToString();
                txtMaKH.Text = "KH" + dem;
            }
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {
            taoMaKH();

            string[] gioitinh = { "Nam", "Nữ" };
            foreach (string c in gioitinh)
            {
                cbGT.Items.Add(c);
            }
        }
    }
}
