namespace QuanLiKhachSan
{
    partial class frmChuongTrinh
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
            this.txtLoaiTK = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDangKyDV = new System.Windows.Forms.Button();
            this.btnCapNhatPhong = new System.Windows.Forms.Button();
            this.btnTraCuuKH = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(649, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Loại tài khoản";
            // 
            // txtLoaiTK
            // 
            this.txtLoaiTK.Location = new System.Drawing.Point(650, 69);
            this.txtLoaiTK.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoaiTK.MaximumSize = new System.Drawing.Size(151, 200);
            this.txtLoaiTK.MaxLength = 40000;
            this.txtLoaiTK.Name = "txtLoaiTK";
            this.txtLoaiTK.ReadOnly = true;
            this.txtLoaiTK.Size = new System.Drawing.Size(139, 20);
            this.txtLoaiTK.TabIndex = 16;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(671, 115);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(85, 38);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(42, 39);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(93, 60);
            this.btnDatPhong.TabIndex = 18;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(42, 246);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(93, 60);
            this.btnThanhToan.TabIndex = 19;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDangKyDV
            // 
            this.btnDangKyDV.Location = new System.Drawing.Point(42, 138);
            this.btnDangKyDV.Name = "btnDangKyDV";
            this.btnDangKyDV.Size = new System.Drawing.Size(93, 60);
            this.btnDangKyDV.TabIndex = 20;
            this.btnDangKyDV.Text = "Đăng ký dịch vụ";
            this.btnDangKyDV.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatPhong
            // 
            this.btnCapNhatPhong.Location = new System.Drawing.Point(226, 138);
            this.btnCapNhatPhong.Name = "btnCapNhatPhong";
            this.btnCapNhatPhong.Size = new System.Drawing.Size(93, 60);
            this.btnCapNhatPhong.TabIndex = 21;
            this.btnCapNhatPhong.Text = "Cập nhật tình trạng phòng";
            this.btnCapNhatPhong.UseVisualStyleBackColor = true;
            this.btnCapNhatPhong.Click += new System.EventHandler(this.btnCapNhatPhong_Click);
            // 
            // btnTraCuuKH
            // 
            this.btnTraCuuKH.Location = new System.Drawing.Point(226, 39);
            this.btnTraCuuKH.Name = "btnTraCuuKH";
            this.btnTraCuuKH.Size = new System.Drawing.Size(93, 60);
            this.btnTraCuuKH.TabIndex = 22;
            this.btnTraCuuKH.Text = "Tra cứu khách hàng";
            this.btnTraCuuKH.UseVisualStyleBackColor = true;
            this.btnTraCuuKH.Click += new System.EventHandler(this.btnTraCuuKH_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(226, 246);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(93, 60);
            this.btnLapPhieu.TabIndex = 23;
            this.btnLapPhieu.Text = "Lập phiếu đặt phòng";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // frmChuongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.btnTraCuuKH);
            this.Controls.Add(this.btnCapNhatPhong);
            this.Controls.Add(this.btnDangKyDV);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtLoaiTK);
            this.Controls.Add(this.label1);
            this.Name = "frmChuongTrinh";
            this.Text = "ChuongTrinh";
            this.Load += new System.EventHandler(this.frmChuongTrinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnDangKyDV;
        private System.Windows.Forms.Button btnCapNhatPhong;
        private System.Windows.Forms.Button btnTraCuuKH;
        private System.Windows.Forms.Button btnLapPhieu;
    }
}