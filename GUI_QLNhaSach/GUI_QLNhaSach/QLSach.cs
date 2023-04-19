using BUS_QLNhaSach;
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
    public partial class QLSach : UserControl
    {
        BUS_QuanLi busql = new BUS_QuanLi();

        public QLSach()
        {
            InitializeComponent();
            loadTheLoai();
            loadNXB();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void loadTheLoai()
        {
            cbTheLoai.DataSource = busql.getTheLoai();
            cbTheLoai.DisplayMember = "Ten";
        }

        private void loadNXB()
        {
            cbNXB.DataSource = busql.getNXB();
            cbNXB.DisplayMember = "TenNXB";
        }
    }
}
