using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_KhachHang
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        KHACHHANG _kh = new KHACHHANG();

        public List<KHACHHANG> Loadkhachhang()
        {
            return _db.KHACHHANGs.Select(p => p).ToList<KHACHHANG>();
        }
        public bool Themkhachhang(KHACHHANG khachhang)
        {
            try
            {
                _db.KHACHHANGs.InsertOnSubmit(khachhang);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Xoakhachhang(KHACHHANG khachhang)
        {
            _kh = _db.KHACHHANGs.Where(p => p.ID == khachhang.ID).SingleOrDefault();
            _db.KHACHHANGs.DeleteOnSubmit(_kh);
            _db.SubmitChanges();
        }
        public void Suakhachhang(KHACHHANG khachhang)
        {
            _kh = _db.KHACHHANGs.Where(p => p.ID == khachhang.ID).SingleOrDefault();
            _kh.HOTENKH = khachhang.HOTENKH;
            _kh.SDT = khachhang.SDT;
            _kh.EMAIL = khachhang.EMAIL;
            _kh.DIACHI = khachhang.DIACHI;
            _kh.CMND = khachhang.CMND;
            _db.SubmitChanges();
        }
    }
}
