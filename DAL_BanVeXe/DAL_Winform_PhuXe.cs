using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_PhuXe
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        PHUXE _px = new PHUXE();

        public List<PHUXE> Loadphuxe()
        {
            return _db.PHUXEs.Select(p => p).ToList<PHUXE>();
        }
        public bool Themphuxe(PHUXE phuxe)
        {
            try
            {
                _db.PHUXEs.InsertOnSubmit(phuxe);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Xoaphuxe(PHUXE phuxe)
        {
            _px = _db.PHUXEs.Where(p => p.ID == phuxe.ID).SingleOrDefault();
            _db.PHUXEs.DeleteOnSubmit(_px);
            _db.SubmitChanges();
        }
        public void Suaphuxe(PHUXE phuxe)
        {
            _px = _db.PHUXEs.Where(p => p.ID == phuxe.ID).SingleOrDefault();
            _px.ID_LOAINV = phuxe.ID_LOAINV;
            _px.HOTENPX = phuxe.HOTENPX;
            _px.NGAYSINH = phuxe.NGAYSINH;
            _px.GIOITINH = phuxe.GIOITINH;
            _px.SDT = phuxe.SDT;
            _px.DIACHI = phuxe.DIACHI;
            _db.SubmitChanges();
        }
    }
}
