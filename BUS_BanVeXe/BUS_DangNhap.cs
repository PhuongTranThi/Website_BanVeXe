using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dal_dangnhap = new DAL_DangNhap();

        public bool DangNhap(string email, string pass)
        {
            return dal_dangnhap.DangNhap(email, pass);
        }
        public KHACHHANG getKhachHang(string email, string pass)
        {
            return dal_dangnhap.SS_DangNhap(email, pass);
        }
        //---------------------------------
        public bool getDangNhap(string user, string pass)
        {
            return dal_dangnhap.getDangNhap(user, pass);
        }

        public USER DangNhapAdmin(string user, string pass)
        {
            return dal_dangnhap.DangNhapAdmin(user, pass);
        }
    }
}
