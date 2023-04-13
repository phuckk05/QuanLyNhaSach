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

namespace GUI_QLNhaSach
{
    public partial class FormQLSach : Form
    {
        BUS_QuanLi busql = new BUS_QuanLi();
        public FormQLSach()
        {
            InitializeComponent();
            loadTheLoai();
            loadNXB();
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
