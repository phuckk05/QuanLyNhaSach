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
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            FormDangNhap f = new FormDangNhap();
            f.Show();

            this.Hide();
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan f = new FormThanhToan();
            f.Show();
        }

        private void btDangKi_Click(object sender, EventArgs e)
        {
            FormDangKy f = new FormDangKy();
            f.Show();
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            FormThongKe f = new FormThongKe();
            f.Show();
        }
    }
}
