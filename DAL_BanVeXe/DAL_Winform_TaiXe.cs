using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_TaiXe
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        TAIXE _tx = new TAIXE();

        public List<TAIXE> LoadTaiXe()
        {
            return _db.TAIXEs.Select(p => p).ToList<TAIXE>();
        }
        public bool ThemTaiXe(TAIXE taixe)
        {
            try
            {
                _db.TAIXEs.InsertOnSubmit(taixe);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void XoaTaiXe(TAIXE taixe)
        {
            _tx = _db.TAIXEs.Where(p => p.ID == taixe.ID).SingleOrDefault();
            _db.TAIXEs.DeleteOnSubmit(_tx);
            _db.SubmitChanges();
        }
        public void SuaTaiXe(TAIXE taixe)
        {
            _tx = _db.TAIXEs.Where(p => p.ID == taixe.ID).SingleOrDefault();
            _tx.ID_LOAINV = taixe.ID_LOAINV;
            _tx.HOTENTX = taixe.HOTENTX;
            _tx.NGAYSINH = taixe.NGAYSINH;
            _tx.GIOITINH = taixe.GIOITINH;
            _tx.SDT = taixe.SDT;
            _tx.DIACHI = taixe.DIACHI;
            _db.SubmitChanges();
        }
    }
}
