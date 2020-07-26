using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_NoiDen
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();

        public List<NOIDEN> LoadNoiDen()
        {
            return _db.NOIDENs.Select(p => p).ToList<NOIDEN>();
        }
    }
}
