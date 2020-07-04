using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;


namespace BUS_BanVeXe
{
    public class BUS_DatVe
    {
        DAL_DatVe dal_datve = new DAL_DatVe();

        public bool DatVe(DTO_DatVe datve)
        {
            return dal_datve.DatVe(datve);
        }
    }
}
