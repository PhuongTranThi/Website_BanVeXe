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

        public List<TUYENDI> LoadTuyenDi()
        {
            return dal_diadiemdon.LoadTuyenDi();
        }
        public DIADIEMLENXE LoadDDByID(int id)
        {
            return dal_diadiemdon.LoadDDByID(id);
        }
        public bool UpdateDDByID(int id, DIADIEMLENXE dd)
        {
            return dal_diadiemdon.UpdateDDByID(id, dd);
        }
        public bool DeleteDDByID(int id)
        {
            return dal_diadiemdon.DeleteDDByID(id);
        }
        public bool InsertDD(DIADIEMLENXE dd)
        {
            return dal_diadiemdon.InsertDD(dd);
        }
    }
}
