using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiKhachSan
{
    public partial class frmDangNhap : Form
    {
        List<TaiKhoan> listTaiKhoan = DanhSachTaiKhoan.Ininstance.ListTaiKhoan;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Đ_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                frmChuongTrinh f = new frmChuongTrinh();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai. Nhập lại", "Lỗi");
                txtTaiKhoan.Focus();
            }
        }

        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            for (int i = 0; i < listTaiKhoan.Count; i++)
            {
                if (tentaikhoan == listTaiKhoan[i].TaiKhoanName && matkhau == listTaiKhoan[i].Matkhau)
                {
                    Const.TaiKhoan = listTaiKhoan[i];
                    return true;
                }
            }
            return false;
        }
    }
}
