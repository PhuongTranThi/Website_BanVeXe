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

        //load chuyen admin
        public List<DTO_Admin_ChuyenDi> LoadChuyenAdmin()
        {
            var phuong = from chuyen in _db.CHUYENDIs
                            from tuyen in _db.TUYENDIs
                            from xe in _db.XEs
                            from taixe in _db.TAIXEs
                            from phuxe in _db.PHUXEs
                            where chuyen.ID_TUYENDI == tuyen.ID
                            && chuyen.ID_XE == xe.ID
                            && chuyen.ID_TAIXE1 == taixe.ID
                            && chuyen.ID_PHUXE == phuxe.ID
                            select new
                            {
                                id_chuyen = chuyen.ID,
                                id_xe = chuyen.ID_XE,
                                id_tuyen = chuyen.ID_TUYENDI,
                                id_tentaixe1 = chuyen.ID_TAIXE1,
                                id_tentaixe2 = chuyen.ID_TAIXE2,
                                id_phuxe = chuyen.ID_PHUXE,
                                ngaykhoihanh = chuyen.NGAYKHOIHANH,
                                giodi = chuyen.GIODI,
                                tentuyendi = tuyen.TENTUYEN,
                                bienso = xe.BIENSO,
                                tentaixe1 = taixe.HOTENTX,
                                tentaixe2 = taixe.HOTENTX,
                                tenphuxe = phuxe.HOTENPX,
                            };
            List<DTO_Admin_ChuyenDi> result = phuong.ToList().ConvertAll(t => new DTO_Admin_ChuyenDi
            {
                ID_ChuyenDi = t.id_chuyen,
                ID_Xe = int.Parse(t.id_xe.ToString()),
                ID_TaiXe1 = int.Parse(t.id_tentaixe1.ToString()),
                ID_TaiXe2 = int.Parse(t.id_tentaixe2.ToString()),
                ID_PhuXe = int.Parse(t.id_phuxe.ToString()),
                ID_TuyenDi = int.Parse(t.id_tuyen.ToString()),
                NgayKhoiHanh = t.ngaykhoihanh.ToString(),
                GioDi = t.giodi.ToString(),
                TenTuyenDi = t.tentuyendi,
                BienSoXe = t.bienso,
                TenPhuXe = t.tenphuxe,
                TenTaiXe1 = t.tentaixe1,
                TenTaiXe2 = t.tentaixe2
            });
            return result.ToList<DTO_Admin_ChuyenDi>();
        }
    }
}
