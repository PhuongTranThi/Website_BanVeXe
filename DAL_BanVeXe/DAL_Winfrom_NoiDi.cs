using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winfrom_NoiDi
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();

        public List<NOIDI> LoadNoiDi()
        {
            return _db.NOIDIs.Select(p => p).ToList<NOIDI>();
        }
    }
}
