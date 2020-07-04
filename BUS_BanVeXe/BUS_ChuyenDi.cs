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
        public List<DTO_ChuyenDi> Load_Tuyen_BienSo(int id_chuyen)
        {
            return dal_chuyendi.LoadTuyen_BienSo(id_chuyen);
        }
        public List<DIADIEMLENXE> LoadDiaDiemLenXe(int id_diadiem)
        {
            // [{tenddd: "ten"}]
            return dal_chuyendi.LoadDiaDiemLenXe(id_diadiem);
        }
    }
}
