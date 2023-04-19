
namespace GUI_QLNhaSach
{
    partial class FormQL
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
            this.QuanLi = new System.Windows.Forms.SplitContainer();
            this.btQLNCC = new System.Windows.Forms.Button();
            this.btQLHD = new System.Windows.Forms.Button();
            this.btQLS = new System.Windows.Forms.Button();
            this.btQLKH = new System.Windows.Forms.Button();
            this.btQLNV = new System.Windows.Forms.Button();
            this.qlHoaDon1 = new GUI_QLNhaSach.QLHoaDon();
            this.qlnCungCap1 = new GUI_QLNhaSach.QLNCungCap();
            this.qlKhachHang1 = new GUI_QLNhaSach.QLKhachHang();
            this.qlSach1 = new GUI_QLNhaSach.QLSach();
            this.qlNhanVien1 = new GUI_QLNhaSach.QLNhanVien();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLi)).BeginInit();
            this.QuanLi.Panel1.SuspendLayout();
            this.QuanLi.Panel2.SuspendLayout();
            this.QuanLi.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuanLi
            // 
            this.QuanLi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuanLi.Location = new System.Drawing.Point(0, 0);
            this.QuanLi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QuanLi.Name = "QuanLi";
            // 
            // QuanLi.Panel1
            // 
            this.QuanLi.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.QuanLi.Panel1.Controls.Add(this.btQLNCC);
            this.QuanLi.Panel1.Controls.Add(this.btQLHD);
            this.QuanLi.Panel1.Controls.Add(this.btQLS);
            this.QuanLi.Panel1.Controls.Add(this.btQLKH);
            this.QuanLi.Panel1.Controls.Add(this.btQLNV);
            // 
            // QuanLi.Panel2
            // 
            this.QuanLi.Panel2.BackColor = System.Drawing.Color.LightGray;
            this.QuanLi.Panel2.Controls.Add(this.qlHoaDon1);
            this.QuanLi.Panel2.Controls.Add(this.qlnCungCap1);
            this.QuanLi.Panel2.Controls.Add(this.qlKhachHang1);
            this.QuanLi.Panel2.Controls.Add(this.qlSach1);
            this.QuanLi.Panel2.Controls.Add(this.qlNhanVien1);
            this.QuanLi.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.QuanLi.Size = new System.Drawing.Size(1297, 502);
            this.QuanLi.SplitterDistance = 230;
            this.QuanLi.SplitterWidth = 3;
            this.QuanLi.TabIndex = 0;
            // 
            // btQLNCC
            // 
            this.btQLNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQLNCC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btQLNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLNCC.ForeColor = System.Drawing.Color.White;
            this.btQLNCC.Location = new System.Drawing.Point(0, 216);
            this.btQLNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btQLNCC.Name = "btQLNCC";
            this.btQLNCC.Size = new System.Drawing.Size(230, 54);
            this.btQLNCC.TabIndex = 4;
            this.btQLNCC.Text = "Quản lý nhà cung cấp";
            this.btQLNCC.UseVisualStyleBackColor = true;
            this.btQLNCC.Click += new System.EventHandler(this.btQLNCC_Click);
            // 
            // btQLHD
            // 
            this.btQLHD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQLHD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btQLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLHD.ForeColor = System.Drawing.Color.White;
            this.btQLHD.Location = new System.Drawing.Point(0, 162);
            this.btQLHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btQLHD.Name = "btQLHD";
            this.btQLHD.Size = new System.Drawing.Size(230, 54);
            this.btQLHD.TabIndex = 3;
            this.btQLHD.Text = "Quản lý hóa đơn";
            this.btQLHD.UseVisualStyleBackColor = true;
            this.btQLHD.Click += new System.EventHandler(this.btQLHD_Click);
            // 
            // btQLS
            // 
            this.btQLS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQLS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btQLS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLS.ForeColor = System.Drawing.Color.White;
            this.btQLS.Location = new System.Drawing.Point(0, 108);
            this.btQLS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btQLS.Name = "btQLS";
            this.btQLS.Size = new System.Drawing.Size(230, 54);
            this.btQLS.TabIndex = 2;
            this.btQLS.Text = "Quản lý sách";
            this.btQLS.UseVisualStyleBackColor = true;
            this.btQLS.Click += new System.EventHandler(this.btQLS_Click);
            // 
            // btQLKH
            // 
            this.btQLKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLKH.ForeColor = System.Drawing.Color.White;
            this.btQLKH.Location = new System.Drawing.Point(0, 54);
            this.btQLKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btQLKH.Name = "btQLKH";
            this.btQLKH.Size = new System.Drawing.Size(230, 54);
            this.btQLKH.TabIndex = 1;
            this.btQLKH.Text = "Quản lý khách hàng";
            this.btQLKH.UseVisualStyleBackColor = true;
            this.btQLKH.Click += new System.EventHandler(this.btQLKH_Click);
            // 
            // btQLNV
            // 
            this.btQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLNV.ForeColor = System.Drawing.Color.White;
            this.btQLNV.Location = new System.Drawing.Point(0, 0);
            this.btQLNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btQLNV.Name = "btQLNV";
            this.btQLNV.Size = new System.Drawing.Size(230, 54);
            this.btQLNV.TabIndex = 0;
            this.btQLNV.Text = "Quản lý nhân viên";
            this.btQLNV.UseVisualStyleBackColor = true;
            this.btQLNV.Click += new System.EventHandler(this.btQLNhanVien_Click);
            // 
            // qlHoaDon1
            // 
            this.qlHoaDon1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.qlHoaDon1.Location = new System.Drawing.Point(3, 3);
            this.qlHoaDon1.Name = "qlHoaDon1";
            this.qlHoaDon1.Size = new System.Drawing.Size(1065, 504);
            this.qlHoaDon1.TabIndex = 4;
            // 
            // qlnCungCap1
            // 
            this.qlnCungCap1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.qlnCungCap1.Location = new System.Drawing.Point(3, 3);
            this.qlnCungCap1.Name = "qlnCungCap1";
            this.qlnCungCap1.Size = new System.Drawing.Size(1065, 504);
            this.qlnCungCap1.TabIndex = 3;
            // 
            // qlKhachHang1
            // 
            this.qlKhachHang1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.qlKhachHang1.Location = new System.Drawing.Point(3, 3);
            this.qlKhachHang1.Name = "qlKhachHang1";
            this.qlKhachHang1.Size = new System.Drawing.Size(1065, 504);
            this.qlKhachHang1.TabIndex = 2;
            // 
            // qlSach1
            // 
            this.qlSach1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.qlSach1.Location = new System.Drawing.Point(3, 3);
            this.qlSach1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qlSach1.Name = "qlSach1";
            this.qlSach1.Size = new System.Drawing.Size(1065, 504);
            this.qlSach1.TabIndex = 1;
            // 
            // qlNhanVien1
            // 
            this.qlNhanVien1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.qlNhanVien1.Location = new System.Drawing.Point(3, 3);
            this.qlNhanVien1.Name = "qlNhanVien1";
            this.qlNhanVien1.Size = new System.Drawing.Size(1065, 504);
            this.qlNhanVien1.TabIndex = 0;
            // 
            // FormQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1297, 502);
            this.Controls.Add(this.QuanLi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhà sách";
            this.QuanLi.Panel1.ResumeLayout(false);
            this.QuanLi.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLi)).EndInit();
            this.QuanLi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer QuanLi;
        private System.Windows.Forms.Button btQLNV;
        private System.Windows.Forms.Button btQLNCC;
        private System.Windows.Forms.Button btQLHD;
        private System.Windows.Forms.Button btQLS;
        private System.Windows.Forms.Button btQLKH;
        private QLNhanVien qlNhanVien1;
        private QLSach qlSach1;
        private QLHoaDon qlHoaDon1;
        private QLNCungCap qlnCungCap1;
        private QLKhachHang qlKhachHang1;
    }
}