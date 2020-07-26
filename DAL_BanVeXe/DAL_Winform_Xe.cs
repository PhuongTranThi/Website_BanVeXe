using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_Xe
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        XE _xe = new XE();
        public List<XE> LoadXe()
        {
            return _db.XEs.Select(p => p).ToList<XE>();
        }
        public bool Them(XE xe)
        {
            try
            {
                _db.XEs.InsertOnSubmit(xe);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Xoa(XE xe)
        {
            _xe = _db.XEs.Where(p => p.ID == xe.ID).SingleOrDefault();
            _db.XEs.DeleteOnSubmit(_xe);
            _db.SubmitChanges();
        }
        public void Sua(XE xe)
        {
            _xe = _db.XEs.Where(p => p.ID == xe.ID).SingleOrDefault();
            _xe.ID_LOAIXE = xe.ID_LOAIXE;
            _xe.BIENSO = xe.BIENSO;
            _xe.TRANGTHAI = xe.TRANGTHAI;
          
            _db.SubmitChanges();
        }
    }
}
