using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_ChuyenDi
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<CHUYENDI> LoadChuyen()
        {
            return _db.CHUYENDIs.Select(p => p).ToList<CHUYENDI>();
        }
    }
}
