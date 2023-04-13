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
            FormDangNhap f = new FormDangNhap();
            f.ShowDialog();
            InitializeComponent();
        }

        private void quảnLíSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormQLSach f = new FormQLSach();
            f.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }

        private void quảnLíNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhaCungCap f = new FormNhaCungCap();
            f.Show();
        }
    }
}
