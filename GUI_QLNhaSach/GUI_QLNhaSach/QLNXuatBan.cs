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
    public partial class QLNXuatBan : UserControl
    {
        BUS_QuanLi busql = new BUS_QuanLi();
        public QLNXuatBan()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTenNXB.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "" && txtEmail.Text != "")
            {
                DTO_NhaXuatBan tv = new DTO_NhaXuatBan(0, txtTenNXB.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text);
                if (busql.themNXB(tv))
                {
                    MessageBox.Show("Thêm thông tin nhà xuất bản thành công !!!", "Thông báo");
                    dataNXB.DataSource = busql.getNXB();
                    reset();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin nhà xuất bản không thành công !!!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập thông tin nhà xuất bản đầy đủ!!!", "Thông báo");
            }
        }

        private void QLNXuatBan_Load(object sender, EventArgs e)
        {
            dataNXB.DataSource = busql.getNXB();
            HeaderText();
            SizeText();
        }

        // nap du lieu xuong text box
        private void loadData()
        {
            int index = this.dataNXB.CurrentCell.RowIndex;
            if (index >= 0)
            {
                this.txtTenNXB.Text = this.dataNXB.Rows[index].Cells[1].Value.ToString();
                this.txtDiaChi.Text = this.dataNXB.Rows[index].Cells[2].Value.ToString();
                this.txtEmail.Text = this.dataNXB.Rows[index].Cells[3].Value.ToString();
                this.txtSDT.Text = this.dataNXB.Rows[index].Cells[4].Value.ToString();

            }
        }

        // chinh tieu de cot trong data sach
        private void HeaderText()
        {
            this.dataNXB.Columns[0].HeaderText = "Mã nhà xuất bản";
            this.dataNXB.Columns[1].HeaderText = "Tên nhà xuất bản";
            this.dataNXB.Columns[2].HeaderText = "Địa chỉ";
            this.dataNXB.Columns[3].HeaderText = "Email";
            this.dataNXB.Columns[4].HeaderText = "Số điện thoại";
        }

        // chinh kich thuoc cot trong data sach
        private void SizeText()
        {
            this.dataNXB.Columns[0].Width = 150;
            this.dataNXB.Columns[1].Width = 200;
            this.dataNXB.Columns[2].Width = 200;
            this.dataNXB.Columns[3].Width = 200;
            this.dataNXB.Columns[4].Width = 142;
        }

        private void dataNXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
        }

        private void reset()
        {
            txtTenNXB.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dataNXB.SelectedRows.Count > 0)
            {
                if (txtTenNXB.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "" && txtEmail.Text != "")
                {

                    // Tạo DTo
                    DTO_NhaXuatBan tv = new DTO_NhaXuatBan(txtDiaChi.Text, txtEmail.Text, txtSDT.Text);
                    // Sửa
                    if (busql.suaNXB(tv))
                    {
                        MessageBox.Show("Sửa thông tin nhà xuất bản thành công!!!!");
                        dataNXB.DataSource = busql.getNXB();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin nhà xuất bản không thành công!!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin nhà xuất bản sách đầy đủ");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành phần muốn sửa ?");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (dataNXB.SelectedCells.Count > 0)
            {
                if (busql.xoaNXB(txtSDT.Text))
                {
                    MessageBox.Show("Xóa thông tin nhà xuất bản thành công!!!!!!", "Thông báo");
                    dataNXB.DataSource = busql.getNXB();
                }
                else 
                { 
                    MessageBox.Show("Xóa thông tin nhà xuất bản không thành công!!!!!!", "Thông báo"); 
                }
            }
            else 
            { 
                MessageBox.Show("Hãy chọn số điện thoại muốn xóa"); 
            }
        }
    }
}
