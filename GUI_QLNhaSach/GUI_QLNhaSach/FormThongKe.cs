using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BUS_QLNhaSach;

namespace GUI_QLNhaSach
{
    public partial class FormThongKe : Form
    {
        BUS_QuanLi busql = new BUS_QuanLi();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            // bang tong hoa don
            dataTong.DataSource = busql.getTKT();
            HeaderText1();
            SizeText1();
        }

        private void HeaderText1()
        {
            this.dataTong.Columns[0].HeaderText = "Mã hóa đơn";
            this.dataTong.Columns[1].HeaderText = "Số lượng mặt hàng";
            this.dataTong.Columns[2].HeaderText = "Tổng tiền";
        }

        private void SizeText1()
        {
            this.dataTong.Columns[0].Width = 200;
            this.dataTong.Columns[1].Width = 150;
            this.dataTong.Columns[2].Width = 150;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
