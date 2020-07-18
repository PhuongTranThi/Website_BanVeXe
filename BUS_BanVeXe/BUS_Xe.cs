using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;


namespace BUS_BanVeXe
{
    public class BUS_Xe
    {
        DAL_Xe dal_xe = new DAL_Xe();
        public List<DTO_Xe> LoadXe()
        {
            return dal_xe.LoadXe();
        }
    }
}
