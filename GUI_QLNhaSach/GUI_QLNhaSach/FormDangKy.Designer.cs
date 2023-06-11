
namespace GUI_QLNhaSach
{
    partial class FormDangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.cbGT = new System.Windows.Forms.ComboBox();
            this.txtCCCD = new System.Windows.Forms.MaskedTextBox();
            this.txtSDT = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÍ THÀNH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Căn cước công dân";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số điện thoại";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(290, 99);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(262, 34);
            this.txtTenKH.TabIndex = 3;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(290, 161);
            this.txtNgaySinh.Mask = "00/00/0000";
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(193, 34);
            this.txtNgaySinh.TabIndex = 4;
            this.txtNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // cbGT
            // 
            this.cbGT.FormattingEnabled = true;
            this.cbGT.Location = new System.Drawing.Point(708, 99);
            this.cbGT.Name = "cbGT";
            this.cbGT.Size = new System.Drawing.Size(121, 37);
            this.cbGT.TabIndex = 5;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(290, 223);
            this.txtCCCD.Mask = "000000000000";
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(193, 34);
            this.txtCCCD.TabIndex = 6;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(290, 285);
            this.txtSDT.Mask = "0000000000";
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(193, 34);
            this.txtSDT.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCCCD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNgaySinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbGT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(47, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 377);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân của khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(290, 44);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(262, 34);
            this.txtMaKH.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(33, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Mã khách hàng";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.Red;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.White;
            this.btThoat.Image = global::GUI_QLNhaSach.Properties.Resources.Update;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(654, 508);
            this.btThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(169, 69);
            this.btThoat.TabIndex = 36;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btLuu
            // 
            this.btLuu.BackColor = System.Drawing.Color.LimeGreen;
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.White;
            this.btLuu.Image = global::GUI_QLNhaSach.Properties.Resources.bill1;
            this.btLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLuu.Location = new System.Drawing.Point(355, 508);
            this.btLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(273, 69);
            this.btLuu.TabIndex = 37;
            this.btLuu.Text = "Lưu thông tin";
            this.btLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLuu.UseVisualStyleBackColor = false;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // FormDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(939, 610);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí thông tin khách hàng";
            this.Load += new System.EventHandler(this.FormDangKy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.MaskedTextBox txtNgaySinh;
        private System.Windows.Forms.ComboBox cbGT;
        private System.Windows.Forms.MaskedTextBox txtCCCD;
        private System.Windows.Forms.MaskedTextBox txtSDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label7;
    }
}