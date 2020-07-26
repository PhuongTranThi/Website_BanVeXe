using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_ChuyenDi
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        CHUYENDI _cd = new CHUYENDI();
        public List<CHUYENDI> LoadChuyenDi()
        {
            return _db.CHUYENDIs.Select(p => p).ToList<CHUYENDI>();
        }
        public bool ThemChuyenDi(CHUYENDI chuyendi)
        {
            try
            {
                _db.CHUYENDIs.InsertOnSubmit(chuyendi);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void XoaChuyenDi(CHUYENDI chuyendi)
        {
            _cd = _db.CHUYENDIs.Where(p => p.ID == chuyendi.ID).SingleOrDefault();
            _db.CHUYENDIs.DeleteOnSubmit(_cd);
            _db.SubmitChanges();
        }
        public void SuaChuyenDi(CHUYENDI chuyendi)
        {
            _cd = _db.CHUYENDIs.Where(p => p.ID == chuyendi.ID).SingleOrDefault();

            _cd.ID_TUYENDI = chuyendi.ID_TUYENDI;
            _cd.ID_XE = chuyendi.ID_XE;
            _cd.ID_TAIXE = chuyendi.ID_TAIXE;
            _cd.ID_PHUXE = chuyendi.ID_PHUXE;
            _cd.NGAYKHOIHANH = chuyendi.NGAYKHOIHANH;
            _cd.GIODI = chuyendi.GIODI;
            _db.SubmitChanges();
        }
    }
}
