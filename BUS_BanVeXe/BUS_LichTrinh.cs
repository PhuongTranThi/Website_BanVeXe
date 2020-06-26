using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_LichTrinh
    {
        DAL_LichTrinh dal_lichtrinh = new DAL_LichTrinh();

        public List<DTO_LichTrinh> LoadLichTrinh()
        {
            return dal_lichtrinh.LoadLichTrinh();
        }

    }
}
