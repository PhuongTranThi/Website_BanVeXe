using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_KhachHang
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<KHACHHANG> LoadKhachHang()
        {
            return _db.KHACHHANGs.Select(p => p).ToList<KHACHHANG>();
        }
    }
}
