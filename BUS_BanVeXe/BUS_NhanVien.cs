using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_nhanvien = new DAL_NhanVien();
        public List<DTO_TaiXe> LoadTaiXe()
        {
            return dal_nhanvien.LoadTaiXe();
        }
        public List<DTO_PhuXe> LoadPhuXe()
        {
            return dal_nhanvien.LoadPhuXe();
        }
        public List<DTO_NhanVienBanVe> LoadNVBanVe()
        {
            return dal_nhanvien.LoadNhanVienBanVe();
        }
    }
}
