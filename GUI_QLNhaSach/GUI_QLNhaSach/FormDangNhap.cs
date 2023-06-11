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
            {
                 MessageBox.Show("Tên đăng nhập hoặc mật khẩu bị rỗng!!!", "Thông báo");
            }    
            else
            {
                if (txtTenDangNhap.Text == "admin")
                {
                    if (txtMatKhau.Text == "admin")
                    {
                        FormQL f = new FormQL();
                        this.Hide();
                        f.ShowDialog();
                    }
                    else
                    {
                        if (txtMatKhau.Text == "123456")
                        {
                            FormTrangChu k = new FormTrangChu();
                            this.Hide();
                            k.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Nhập mật khẩu sai sai!!", "Thông báo");
                            txtMatKhau.Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nhập tên đăng nhập sai!!", "Thông báo");
                    txtTenDangNhap.Text = "";
                }
            }    
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // phim tat enter de dang nhap
        private void FormDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btDangNhap.PerformClick();
            }    
        }
    }
}
