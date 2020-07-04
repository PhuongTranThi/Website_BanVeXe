using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_TuyenDi
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        TUYENDI _tuyendi = new TUYENDI();
        NOIDI _noidi = new NOIDI();
        NOIDEN _noiden = new NOIDEN();

        public List<TUYENDI> LoadTuyenDi()
        {
            return _db.TUYENDIs.Select(p => p).ToList<TUYENDI>();

        }
        public List<NOIDI> LoadNoiDi()
        {
            return _db.NOIDIs.Select(p => p).ToList<NOIDI>();

        }
        public List<NOIDEN> LoadNoiDen()
        {
            return _db.NOIDENs.Select(p => p).ToList<NOIDEN>();
           

        }

      
    }
}
