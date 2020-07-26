using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_LoaiNhanVien
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();

        public List<LOAINHANVIEN> LoadLoaiNhanVien()
        {
            return _db.LOAINHANVIENs.Select(p => p).ToList<LOAINHANVIEN>();
        }
    }
}
