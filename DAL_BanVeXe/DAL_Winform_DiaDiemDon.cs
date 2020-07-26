using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_DiaDiemDon
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        DIADIEMLENXE _dd = new DIADIEMLENXE();

        public List<DIADIEMLENXE> Loaddiadiemlenxe()
        {
            return _db.DIADIEMLENXEs.Select(p => p).ToList<DIADIEMLENXE>();
        }
        public bool Themdiadiemlenxe(DIADIEMLENXE diadiemlenxe)
        {
            try
            {
                _db.DIADIEMLENXEs.InsertOnSubmit(diadiemlenxe);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Xoadiadiemlenxe(DIADIEMLENXE diadiemlenxe)
        {
            _dd = _db.DIADIEMLENXEs.Where(p => p.ID == diadiemlenxe.ID).SingleOrDefault();
            _db.DIADIEMLENXEs.DeleteOnSubmit(_dd);
            _db.SubmitChanges();
        }
        public void Suadiadiemlenxe(DIADIEMLENXE diadiemlenxe)
        {
            _dd = _db.DIADIEMLENXEs.Where(p => p.ID == diadiemlenxe.ID).SingleOrDefault();
            _dd.ID_TUYENDI = diadiemlenxe.ID_TUYENDI;
            _dd.TENDD = diadiemlenxe.TENDD;
           
            _db.SubmitChanges();
        }
    }
}
