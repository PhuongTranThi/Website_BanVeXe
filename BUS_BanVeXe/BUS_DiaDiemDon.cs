using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_DiaDiemDon
    {
        DAL_DiaDiemDon dal_diadiemdon = new DAL_DiaDiemDon();
        public List<DTO_DiaDiemDon> LoadDiaDiemDon()
        {
            return dal_diadiemdon.LoadDiaDiemDon();
        }
    }
}
