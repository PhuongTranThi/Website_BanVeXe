using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_ChuyenDi
    {
        DAL_ChuyenDi dal_chuyendi = new DAL_ChuyenDi();

        public List<CHUYENDI> LoadChuyenDi()
        {
            return dal_chuyendi.LoadChuyen();
        }
    }
}
