using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_TuyenDi
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        TUYENDI _td = new TUYENDI();

        public List<TUYENDI> LoadTuyenDi()
        {
            return _db.TUYENDIs.Select(p => p).ToList<TUYENDI>();
        }
        public bool ThemTuyenDi(TUYENDI tuyendi)
        {
            try
            {
                _db.TUYENDIs.InsertOnSubmit(tuyendi);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void XoaTuyenDi(TUYENDI tuyendi)
        {
            _td = _db.TUYENDIs.Where(p => p.ID == tuyendi.ID).SingleOrDefault();
            _db.TUYENDIs.DeleteOnSubmit(_td);
            _db.SubmitChanges();
        }
        public void SuaTuyenDi(TUYENDI tuyendi)
        {
            _td = _db.TUYENDIs.Where(p => p.ID == tuyendi.ID).SingleOrDefault();
            _td.ID_NOIDI = tuyendi.ID_NOIDI;
            _td.ID_NOIDEN = tuyendi.ID_NOIDEN;
            _td.ID_LOAIXE = tuyendi.ID_LOAIXE;
            _td.TENTUYEN = tuyendi.TENTUYEN;
            _td.DONGIA = tuyendi.DONGIA;
            _td.KHOANGCACH = tuyendi.KHOANGCACH;
            _td.SOGIOCHAY = tuyendi.SOGIOCHAY;
            _db.SubmitChanges();
        }
    }
}
