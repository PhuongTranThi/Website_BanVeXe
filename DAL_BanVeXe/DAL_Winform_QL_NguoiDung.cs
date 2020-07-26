using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_QL_NguoiDung
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();

        public List<QL_NGUOIDUNG> LoadNguoiDung()
        {
            return _db.QL_NGUOIDUNGs.Select(p => p).ToList<QL_NGUOIDUNG>();
        }
    }
}
