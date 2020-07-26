using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_PhanQuyen
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<QL_NHOMNGUOIDUNG> LoadNhomNguoiDung()
        {
            return _db.QL_NHOMNGUOIDUNGs.Select(p => p).ToList<QL_NHOMNGUOIDUNG>();
        }

        public List<QL_PHANQUYEN> LoadPhanQuyen()
        {
            return _db.QL_PHANQUYENs.Select(p => p).ToList<QL_PHANQUYEN>();
        }

        public List<DM_MANHINH> LoadManHinh()
        {
            return _db.DM_MANHINHs.Select(p => p).ToList<DM_MANHINH>();
        }

        public string MaNhomNguoiDung { get; set; }
        public string MaManHinh { get; set; }
        public bool CoQuyen { get; set; }
    }
}
