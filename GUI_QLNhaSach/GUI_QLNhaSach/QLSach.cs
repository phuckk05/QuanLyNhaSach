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
using DTO_QLNhaSach;

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

        private void QLSach_Load(object sender, EventArgs e)
        {
            dataSach.DataSource = busql.getSach();
            HeaderText();
            SizeText();
        }

        private void dataSach_CellContentClick(object sender, DataGridViewCellEventArgs e) {}

        private void dataSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
        }

        private void loadData ()
        {
            int index = this.dataSach.CurrentCell.RowIndex;
            if (index >= 0)
            {
                this.txtId.Text = this.dataSach.Rows[index].Cells[0].Value.ToString();
                this.txtTenSach.Text = this.dataSach.Rows[index].Cells[1].Value.ToString();
                this.txtTacGia.Text = this.dataSach.Rows[index].Cells[2].Value.ToString();
                this.txtDonGia.Text = this.dataSach.Rows[index].Cells[3].Value.ToString();
                this.txtSL.Text = this.dataSach.Rows[index].Cells[4].Value.ToString();

            }
        }
        
        // chinh tieu de cot 
        private void HeaderText()
        {
            this.dataSach.Columns[0].HeaderText = "Mã sách";
            this.dataSach.Columns[1].HeaderText = "Tên sách";
            this.dataSach.Columns[2].HeaderText = "Tác giả";
            this.dataSach.Columns[3].HeaderText = "Đơn giá";
            this.dataSach.Columns[4].HeaderText = "Số lượng";
        }

        // chinh kich thuoc cot
        private void SizeText()
        {
            this.dataSach.Columns[0].Width = 150;
            this.dataSach.Columns[1].Width = 200;
            this.dataSach.Columns[2].Width = 200;
            this.dataSach.Columns[3].Width = 200;
            this.dataSach.Columns[4].Width = 150;
        }

        private void reset()
        {
            txtTenSach.Text = "";
            txtTacGia.Text = "";
            txtSL.Text = "";
            txtId.Text = "";
            txtDonGia.Text = "";
            cbNXB.Text = "";
            cbTheLoai.Text = "";
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtSL.Text != "" && txtId.Text != "" && txtDonGia.Text != "")
            {

                int gia = Convert.ToInt32(txtDonGia.Text);
                int sl = Convert.ToInt32(txtSL.Text);
                DTO_Sach tv = new DTO_Sach(txtId.Text, txtTenSach.Text, txtTacGia.Text, gia, sl, cbTheLoai.SelectedIndex + 1, cbNXB.SelectedIndex + 1);
                if (busql.themSach(tv))
                {
                    MessageBox.Show("Thêm thông tin sách thành công !!!", "Thông báo");
                    dataSach.DataSource = busql.getSach();
                    reset();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin không thành công !!!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập thông tin đầy đủ!!!", "Thông báo");
            }
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dataSach.SelectedRows.Count > 0)
            {
                if (txtTenSach.Text != "" && txtDonGia.Text != "" && txtSL.Text != "")
                {
                    int gia = Convert.ToInt32(txtDonGia.Text);
                    int sl = Convert.ToInt32(txtSL.Text);
                    // Tạo DTo
                    DTO_Sach tv = new DTO_Sach(txtId.Text, txtTenSach.Text, gia, sl);
                    // Sửa
                    if (busql.suaSach(tv))
                    {
                        MessageBox.Show("Sửa thông tin sách thành công!!!!", "Thông báo");
                        dataSach.DataSource = busql.getSach();
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin sách không thành công!!!!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin sách đầy đủ", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành phần muốn sửa ?", "Thông báo");
            }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {

            if (dataSach.SelectedCells.Count > 0)
            {
                if (busql.xoaSach(txtId.Text))
            {
                MessageBox.Show("Xóa thông tin sách thành công!!!!!!", "Thông báo");
                dataSach.DataSource = busql.getSach();
            }
                else
                { 
                    MessageBox.Show("Xóa thông tin sách không thành công!!!!!!", "Thông báo"); 
                }
            }
            else
            { 
                MessageBox.Show("Hãy mã sách muốn xóa!!!!!", "Thông báo"); 
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {           
            if ( txtTimKiem.Text == "")
            {
                dataSach.DataSource = busql.getSach();
            } 
            else
            {
                dataSach.DataSource = busql.TimKiem(txtTimKiem.Text);
            }    
        }

        
    }
}
