using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiKhachSan
{
    internal class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;
        public static DanhSachTaiKhoan Ininstance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            }
            set { instance = value; }
        }

        List<TaiKhoan> listTaiKhoan;
        public List<TaiKhoan> ListTaiKhoan
        {
            get { return listTaiKhoan; }
            set { listTaiKhoan = value; }
        }

        DanhSachTaiKhoan()
        {
            listTaiKhoan = new List<TaiKhoan>();
            listTaiKhoan.Add(new TaiKhoan("nhanvienletan", "nhanvienletan", TaiKhoan.LoaiTK.nhanvienletan));
            listTaiKhoan.Add(new TaiKhoan("khachhang", "khachhang", TaiKhoan.LoaiTK.khachhang));

        }
    }
}
