using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLNhaSach
{
    public partial class FormQL : Form
    {
        public FormQL()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btQLNhanVien_Click(object sender, EventArgs e)
        {
            qlNhanVien1.BringToFront();        
        }

        private void btQLNCC_Click(object sender, EventArgs e)
        {
            qlnCungCap1.BringToFront();
        }

        private void btQLS_Click(object sender, EventArgs e)
        {
            qlSach1.BringToFront();
        }

        private void btQLKH_Click(object sender, EventArgs e)
        {
            qlKhachHang1.BringToFront();
        }

        private void btQLHD_Click(object sender, EventArgs e)
        {
            qlHoaDon1.BringToFront();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();

            this.Hide();
        }
    }
}
