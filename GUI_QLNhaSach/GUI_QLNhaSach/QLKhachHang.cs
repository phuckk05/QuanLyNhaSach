using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLNhaSach;
using BUS_QLNhaSach;

namespace GUI_QLNhaSach
{
    public partial class QLKhachHang : UserControl
    {
        BUS_QuanLi busql = new BUS_QuanLi();
        public QLKhachHang()
        {
            InitializeComponent();
        }

        private void QLKhachHang_Load(object sender, EventArgs e)
        {
            taoMaKH();

            string[] gioitinh = { "Nam", "Nữ" };
            foreach (string c in gioitinh)
            {
                cbGT.Items.Add(c);
            }

            dataKH.DataSource = busql.getKH();
            HeaderText();
            SizeText();
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

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text != "" && txtNgaySinh.Text != "" && txtCCCD.Text != "" && txtSDT.Text != "")
            {
                DTO_KhachHang tv = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtSDT.Text);

                if (busql.themKH(tv))
                {
                    MessageBox.Show("Thêm thông tin khách hàng thành công !!!", "Thông báo");
                    dataKH.DataSource = busql.getKH();
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

        private void btSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dataKH.SelectedRows.Count > 0)
            {
                if (txtTenKH.Text != "" && txtNgaySinh.Text != "" && txtCCCD.Text != "" && txtSDT.Text != "")
                {

                    DTO_KhachHang tv = new DTO_KhachHang(txtMaKH.Text, txtTenKH.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtSDT.Text);
                    if (busql.suaKH(tv))
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thành công!!!!", "Thông báo");
                        dataKH.DataSource = busql.getKH();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin khách hàng không thành công!!!!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin sách đầy đủ", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy mã khách hàng muốn sửa ?", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataKH.SelectedCells.Count > 0)
            {
                if (busql.xoaKH(txtMaKH.Text))
                {
                    MessageBox.Show("Xóa thông tin khách hàng thành công!!!!!!", "Thông báo");
                    dataKH.DataSource = busql.getKH();
                    taoMaKH();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin khách hàng không thành công!!!!!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy mã khách hàng muốn xóa!!!!!", "Thông báo");
            }
        }

        // nap du lieu xuong text box
        private void loadData()
        {
            int index = this.dataKH.CurrentCell.RowIndex;
            if (index >= 0)
            {
                this.txtMaKH.Text = this.dataKH.Rows[index].Cells[0].Value.ToString();
                this.txtTenKH.Text = this.dataKH.Rows[index].Cells[1].Value.ToString();
                this.txtNgaySinh.Text = this.dataKH.Rows[index].Cells[2].Value.ToString();
                this.cbGT.Text = this.dataKH.Rows[index].Cells[3].Value.ToString();
                this.txtCCCD.Text = this.dataKH.Rows[index].Cells[4].Value.ToString();
                this.txtSDT.Text = this.dataKH.Rows[index].Cells[5].Value.ToString();
            }
        }

        // chinh tieu de cot trong data sach
        private void HeaderText()
        {
            this.dataKH.Columns[0].HeaderText = "Mã khách hàng";
            this.dataKH.Columns[1].HeaderText = "Tên khách hàng";
            this.dataKH.Columns[2].HeaderText = "Ngày sinh";
            this.dataKH.Columns[3].HeaderText = "Giới tính";
            this.dataKH.Columns[4].HeaderText = "CCCD";
            this.dataKH.Columns[5].HeaderText = "SDT";
        }

        // chinh kich thuoc cot trong data sach
        private void SizeText()
        {
            this.dataKH.Columns[0].Width = 150;
            this.dataKH.Columns[1].Width = 200;
            this.dataKH.Columns[2].Width = 150;
            this.dataKH.Columns[3].Width = 100;
            this.dataKH.Columns[4].Width = 150;
            this.dataKH.Columns[5].Width = 150;
        }

        private void reset()
        {
            txtTenKH.Text = "";
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            cbGT.Text = "";
        }

        private void dataKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
        }
    }
}
