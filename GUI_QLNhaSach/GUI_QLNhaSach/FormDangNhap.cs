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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "" || txtMatKhau.Text == "")
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu bị rỗng!!!");
            if (txtTenDangNhap.Text == "admin")
            {
                if (txtMatKhau.Text == "admin")
                {
                    FormQL f = new FormQL();
                    f.Show();
                }
                else if (txtMatKhau.Text == "123456")
                {
                    FormTrangChu k = new FormTrangChu();
                    k.Show();
                }                
            }           
            else
            {
                MessageBox.Show("Nhập tên đăng nhập sai!!");
            } 
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtTenDangNhap.Text == "")
                Application.Exit();
        }

        private void btThoat_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FormDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btDangNhap.PerformClick();
            }    
        }
    }
}
