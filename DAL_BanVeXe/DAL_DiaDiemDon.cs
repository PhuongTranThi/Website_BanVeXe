using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_DiaDiemDon
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<DTO_DiaDiemDon> LoadDiaDiemDon()
        {
            var phuong = from diadiem in _db.DIADIEMLENXEs
                         from tuyen in _db.TUYENDIs
                         where diadiem.ID_TUYENDI == tuyen.ID
                         select new
                         {
                             id_dd = diadiem.ID,
                             tendd = diadiem.TENDD,
                             id_tuyendi = tuyen.ID,
                             tentuyen = tuyen.TENTUYEN,
                         };
            List<DTO_DiaDiemDon> result = phuong.ToList().ConvertAll(t => new DTO_DiaDiemDon
            {
                ID_DiaDiem = t.id_dd,
                TenDiaDiem = t.tendd,
                ID_TuyenDi = t.id_tuyendi,
                TenTuyenDi = t.tentuyen

            });
            return result.ToList<DTO_DiaDiemDon>();
        }
    }
}
