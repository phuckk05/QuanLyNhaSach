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
    public partial class QLNhanVien : UserControl
    {
        BUS_QuanLi busql = new BUS_QuanLi();
        public QLNhanVien()
        {
            InitializeComponent();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "" && txtDiaChi.Text != "" && txtCCCD.Text != "" && txtMaNV.Text != "" && txtDiaChi.Text != "")
            {
                DTO_NhanVien tv = new DTO_NhanVien(txtMaNV.Text, txtTen.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtDiaChi.Text, txtSDT.Text );
                if (busql.themNV(tv))
                {
                    MessageBox.Show("Thêm thông tin nhân viên thành công !!!", "Thông báo");
                    dataNV.DataSource = busql.getNV();
                    reset();
                    taoMaNV();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin nhân viên không thành công !!!!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Xin hãy nhập thông tin đầy đủ!!!", "Thông báo");
            }
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            taoMaNV();
            string[] gioitinh = { "Nam", "Nữ"};
            foreach (string c in gioitinh)
            {
                cbGT.Items.Add(c);
            }

            dataNV.DataSource = busql.getNV();
            HeaderText();
            SizeText();
        }

        private void taoMaNV()
        {
            Random random = new Random();
            List<int> numbers = new List<int>();
            int dem = random.Next(100, 999);
            if (!numbers.Contains(dem))
            {
                numbers.Add(dem);
                string so = dem.ToString();
                txtMaNV.Text = "NV" + dem;
            }
        }

        private void reset()
        {
            txtMaNV.Text = "";
            txtTen.Text = "";
            txtNgaySinh.Text = "";
            txtCCCD.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cbGT.Text = "";
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có chọn table rồi
            if (dataNV.SelectedRows.Count > 0)
            {
                if (txtTen.Text != "" && txtDiaChi.Text != "" && txtCCCD.Text != "" && txtMaNV.Text != "" && txtDiaChi.Text != "")
                {
                    // Tạo DTo
                    DTO_NhanVien tv = new DTO_NhanVien(txtMaNV.Text ,txtTen.Text, txtNgaySinh.Text, cbGT.Text, txtCCCD.Text, txtDiaChi.Text, txtSDT.Text);
                    // Sửa
                    if (busql.suaNV(tv))
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công!!!!", "Thông báo");
                        dataNV.DataSource = busql.getNV();
                        reset();
                        taoMaNV();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin nhân viên không thành công!!!!", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập thông tin nhân viên đầy đủ", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành phần muốn sửa ?", "Thông báo");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dataNV.SelectedCells.Count > 0)
            {
                if (busql.xoaNV(txtMaNV.Text))
                {
                MessageBox.Show("Xóa thông tin nhân viên thành công!!!!!!", "Thông báo");
                dataNV.DataSource = busql.getNV();
                taoMaNV();
                }
                else 
                { 
                    MessageBox.Show("Xóa thông tin nhân viên không thành công!!!!!!", "Thông báo"); 
                }
            }
            else 
            { 
                MessageBox.Show("Hãy chọn mã nhân viên muốn xóa!!!!!!", "Thông báo"); 
            }
        }

        // nap du lieu xuong text box
        private void loadData()
        {
            int index = this.dataNV.CurrentCell.RowIndex;
            if (index >= 0)
            {
                this.txtMaNV.Text = this.dataNV.Rows[index].Cells[0].Value.ToString();
                this.txtTen.Text = this.dataNV.Rows[index].Cells[1].Value.ToString();
                this.txtNgaySinh.Text = this.dataNV.Rows[index].Cells[2].Value.ToString();
                this.txtCCCD.Text = this.dataNV.Rows[index].Cells[4].Value.ToString();
                this.txtDiaChi.Text = this.dataNV.Rows[index].Cells[5].Value.ToString();
                this.txtSDT.Text = this.dataNV.Rows[index].Cells[6].Value.ToString();

            }
        }

        // chinh tieu de cot trong data sach
        private void HeaderText()
        {
            this.dataNV.Columns[0].HeaderText = "Mã nhân viên";
            this.dataNV.Columns[1].HeaderText = "Tên nhân viên";
            this.dataNV.Columns[2].HeaderText = "Ngày sinh";
            this.dataNV.Columns[3].HeaderText = "Giới tính";
            this.dataNV.Columns[4].HeaderText = "CCCD";
            this.dataNV.Columns[5].HeaderText = "Địa chỉ";
            this.dataNV.Columns[6].HeaderText = "Số điện thoại";
        }

        // chinh kich thuoc cot trong data sach
        private void SizeText()
        {
            this.dataNV.Columns[0].Width = 150;
            this.dataNV.Columns[1].Width = 200;
            this.dataNV.Columns[2].Width = 200;
            this.dataNV.Columns[3].Width = 150;
            this.dataNV.Columns[4].Width = 150;
            this.dataNV.Columns[5].Width = 200;
            this.dataNV.Columns[6].Width = 150;

        }

        private void dataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
        }

        public void KT(string s)
        {
            //string s = busql.timkiemNgay(txtMaNV.Text);
            
            //if (s.Substring (s.Length(7)))
            
        }


    }
}
