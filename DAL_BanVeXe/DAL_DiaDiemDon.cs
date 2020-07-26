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
        //load tuyến đi
        public List<TUYENDI> LoadTuyenDi()
        {
            return _db.TUYENDIs.Select(p => p).ToList<TUYENDI>();
        }
        //thêm xóa sửa admin
        public DIADIEMLENXE LoadDDByID(int id)
        {
            return _db.DIADIEMLENXEs.Where(p => p.ID == id).SingleOrDefault();
        }

        public bool UpdateDDByID(int id, DIADIEMLENXE dd)
        {
            DIADIEMLENXE update = _db.DIADIEMLENXEs.Where(p => p.ID == id).SingleOrDefault();
            try
            {
                update.ID_TUYENDI = dd.ID_TUYENDI;
                update.TENDD = dd.TENDD;
                _db.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteDDByID(int id)
        {
            try
            {
                DIADIEMLENXE del = _db.DIADIEMLENXEs.Where(p => p.ID == id).SingleOrDefault();
                _db.DIADIEMLENXEs.DeleteOnSubmit(del);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertDD(DIADIEMLENXE dd)
        {
            try
            {
                _db.DIADIEMLENXEs.InsertOnSubmit(dd);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
