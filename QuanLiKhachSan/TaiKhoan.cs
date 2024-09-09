using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    public class TaiKhoan
    {
        private String taikhoan;
        public string TaiKhoanName
        {
            get { return taikhoan; }
            set { taikhoan = value; }
        }

        private String matKhau;
        public string Matkhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        public enum LoaiTK
        {
            nhanvienletan,
            khachhang
        }

        private LoaiTK loaiTaiKhoan;
        public LoaiTK LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }

        private string tenHienThi;
        public string TenHienThi
        {
            get
            {
                switch (LoaiTaiKhoan)
                {
                    case LoaiTK.khachhang:
                        TenHienThi = "Khách hàng";
                        break;
                    case LoaiTK.nhanvienletan:
                        TenHienThi = "Nhân viên lễ tân";
                        break;
                }
                return tenHienThi;
            }
            set { tenHienThi = value; }
        }

        public TaiKhoan(string tentaikhoan, string matkhau, LoaiTK loaitaikhoan)
        {
            this.TaiKhoanName = tentaikhoan;
            this.Matkhau = matkhau;
            this.LoaiTaiKhoan = loaitaikhoan;
        }
    }
}
