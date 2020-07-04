using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_DangKy
    {
        DAL_DangKy dal_dangky = new DAL_DangKy();

        public bool DangKy(DTO_DangKy a)
        {
            return dal_dangky.DangKy(a);
        }
    }
}
