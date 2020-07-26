using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_Ve
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        VE _ve = new VE();

        public List<VE> LoadVe()
        {
            return _db.VEs.Select(p => p).ToList<VE>();
        }
        public void XoaVe(VE ve)
        {
            _ve = _db.VEs.Where(p => p.ID == ve.ID).SingleOrDefault();
            _db.VEs.DeleteOnSubmit(_ve);
            _db.SubmitChanges();
        }

    }
}
