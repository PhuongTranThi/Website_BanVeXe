using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BanVeXe;
using DTO_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_TuyenDi
    {
        DAL_TuyenDi dalTuyenDi = new DAL_TuyenDi();

        public List<TUYENDI> LoadTuyenDi()
        {
            return dalTuyenDi.LoadTuyenDi();
        }
        public List<NOIDI> LoadNoiDi()
        {
            return dalTuyenDi.LoadNoiDi();
        }
        public List<NOIDEN> LoadNoiDen()
        {
            return dalTuyenDi.LoadNoiDen();
        }
    }
}
