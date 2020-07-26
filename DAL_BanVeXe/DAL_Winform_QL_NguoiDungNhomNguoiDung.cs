using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_QL_NguoiDungNhomNguoiDung
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();

        public List<QL_NGUOIDUNGNHOMNGUOIDUNG> LoadNguoiDungNhomNguoiDung()
        {
            return _db.QL_NGUOIDUNGNHOMNGUOIDUNGs.Select(p => p).ToList<QL_NGUOIDUNGNHOMNGUOIDUNG>();
        }
    }
}
