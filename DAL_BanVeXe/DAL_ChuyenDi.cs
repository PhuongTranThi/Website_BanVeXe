using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_ChuyenDi
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<CHUYENDI> LoadChuyen()
        {
            return _db.CHUYENDIs.Select(p => p).ToList<CHUYENDI>();
        }


        public List<DTO_ChuyenDi> LoadTuyen_BienSo(int id_chuyen)
        {
            var tuyendine = from chuyen in _db.CHUYENDIs
                            from tuyen in _db.TUYENDIs
                            from xe in _db.XEs
                            where chuyen.ID_TUYENDI == tuyen.ID
                            && chuyen.ID_XE == xe.ID
                            && chuyen.ID == int.Parse(id_chuyen.ToString())
                            select new
                            {
                                ten_tuyen = tuyen.TENTUYEN,
                                bienso = xe.BIENSO,
                                giokhoihanh = chuyen.GIODI,

                            };
            List<DTO_ChuyenDi> result = tuyendine.ToList().ConvertAll(t => new DTO_ChuyenDi
            {
                TenTuyen = t.ten_tuyen,
                BienSo = t.bienso,
                GioKhoiHanh = t.giokhoihanh.ToString(),
            });
            return result.ToList<DTO_ChuyenDi>();
        }
        public List<DIADIEMLENXE> LoadDiaDiemLenXe(int id_diadiem)
        {
            var diadiem = from dd in _db.DIADIEMLENXEs
                          where dd.ID == int.Parse(id_diadiem.ToString())
                          select new
                          {
                              ten_dd = dd.TENDD,
                          };
            List<DIADIEMLENXE> result = diadiem.ToList().ConvertAll(t => new DIADIEMLENXE
            {
                TENDD = t.ten_dd,
            });
            // [{}]
            return result.ToList<DIADIEMLENXE>();
        }
    }
}
