using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_LoaiXe
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();

        public List<LOAIXE> LoadLoaiXe()
        {
            return _db.LOAIXEs.Select(p => p).ToList<LOAIXE>();
        }
    }
}
