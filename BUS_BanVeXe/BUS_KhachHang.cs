using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_khachhang = new DAL_KhachHang();

        public List<KHACHHANG> LoadKhachHang()
        {
            return dal_khachhang.LoadKhachHang();
        }

        public KHACHHANG LoadKhachHangByID(int id)
        {
            return dal_khachhang.LoadKhachHangByID(id);
        }

        public bool UpdateKhachHangByID(int id,  KHACHHANG kh)
        {
            return dal_khachhang.UpdateKhachHangByID(id, kh);
        }

        public bool DeleteKhachHangByID(int id)
        {
            return dal_khachhang.DeleteKhachHangByID(id);
        }

        public bool InsertKhachHang(KHACHHANG kh)
        {
            return dal_khachhang.InsertKhachHang(kh);
        }
        
    }
}
