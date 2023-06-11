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
    public partial class QLHoaDon : UserControl
    {
        BUS_QuanLi busql = new BUS_QuanLi();
        public QLHoaDon()
        {
            InitializeComponent();
        }

        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            dataDT.DataSource = busql.getTK();
            // bang tung hoa don
            HeaderText();
            SizeText();
            // bang tong hoa don
            dataTong.DataSource = busql.getTKNgay(txtNgay.Text);
            HeaderText1();
            SizeText1();
        }

        private void HeaderText()
        {
            this.dataDT.Columns[0].HeaderText = "Mã hóa đơn";
            this.dataDT.Columns[1].HeaderText = "Ngày bán";
            this.dataDT.Columns[2].HeaderText = "Mã nhân viên";
            this.dataDT.Columns[3].HeaderText = "Mã khách hàng";
            this.dataDT.Columns[4].HeaderText = "Tổng tiền";
        }

        private void SizeText()
        {
            this.dataDT.Columns[0].Width = 180;
            this.dataDT.Columns[1].Width = 150;
            this.dataDT.Columns[2].Width = 180;
            this.dataDT.Columns[3].Width = 180;
            this.dataDT.Columns[4].Width = 180;
        }

        private void HeaderText1()
        {
            this.dataTong.Columns[0].HeaderText = "Mã hóa đơn";
            this.dataTong.Columns[1].HeaderText = "Ngày bán";
            this.dataTong.Columns[2].HeaderText = "Tổng tiền";
        }

        private void SizeText1()
        {
            this.dataTong.Columns[0].Width = 150;
            this.dataTong.Columns[1].Width = 200;
            this.dataTong.Columns[2].Width = 200;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            dataTong.DataSource = busql.getTKNgay(txtNgay.Text);
            txtNgay.Text = "";
        }
    }
}
