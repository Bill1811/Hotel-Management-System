using Capnhatphong;
using Khtracuu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace QuanLiKhachSan
{
    public partial class frmChuongTrinh : Form
    {
        public frmChuongTrinh()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap f = new frmDangNhap();
            f.Show();
        }

        void PhanQuyen()
        {
            switch (Const.TaiKhoan.LoaiTaiKhoan)
            {
                case TaiKhoan.LoaiTK.khachhang:
                    btnTraCuuKH.Enabled = btnLapPhieu.Enabled = btnCapNhatPhong.Enabled = false;
                    break;
                case TaiKhoan.LoaiTK.nhanvienletan:
                    btnThanhToan.Enabled = btnDatPhong.Enabled = btnDangKyDV.Enabled = false;
                    break;            }
            txtLoaiTK.Text = Const.TaiKhoan.TenHienThi;
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            DatPhong f = new DatPhong();
            f.Show();
        }

        private void frmChuongTrinh_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan f = new ThanhToan();
            f.ShowDialog();
        }

        private void btnCapNhatPhong_Click(object sender, EventArgs e)
        {
            CapNhatPhong f = new CapNhatPhong();
            f.Show();
        }

        private void btnTraCuuKH_Click(object sender, EventArgs e)
        {
            FormTC f = new FormTC();
            f.Show();
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            LapPhieuDatPhong f = new LapPhieuDatPhong();
            f.Show();
        }
    }
}
