using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_NVBanVe
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        NHANVIEN _nvbv = new NHANVIEN();

        public List<NHANVIEN> Loadnvbv()
        {
            return _db.NHANVIENs.Select(p => p).ToList<NHANVIEN>();
        }
        public bool Themnvbv(NHANVIEN nvbv)
        {
            try
            {
                _db.NHANVIENs.InsertOnSubmit(nvbv);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Xoanvbv(NHANVIEN nvbv)
        {
            _nvbv = _db.NHANVIENs.Where(p => p.ID == nvbv.ID).SingleOrDefault();
            _db.NHANVIENs.DeleteOnSubmit(_nvbv);
            _db.SubmitChanges();
        }
        public void Suanvbv(NHANVIEN nvbv)
        {
            _nvbv = _db.NHANVIENs.Where(p => p.ID == nvbv.ID).SingleOrDefault();
            _nvbv.ID_LOAINV = nvbv.ID_LOAINV;
            _nvbv.HOTENNV = nvbv.HOTENNV;
            _nvbv.NGAYSINH = nvbv.NGAYSINH;
            _nvbv.GIOITINH = nvbv.GIOITINH;
            _nvbv.SDT = nvbv.SDT;
            _nvbv.DIACHI = nvbv.DIACHI;
            _db.SubmitChanges();
        }
    }
}
