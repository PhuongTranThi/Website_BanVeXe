using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_KhachHang
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<KHACHHANG> LoadKhachHang()
        {
            return _db.KHACHHANGs.Select(p => p).ToList<KHACHHANG>();
        }
        //thêm xóa sửa admin
        public KHACHHANG LoadKhachHangByID(int id)
        {
            return _db.KHACHHANGs.Where(p => p.ID == id).SingleOrDefault();
        }

        public bool UpdateKhachHangByID(int id, KHACHHANG kh)
        {
            KHACHHANG update =  _db.KHACHHANGs.Where(p => p.ID == id).SingleOrDefault();
            try
            {
                update.CMND = kh.CMND;
                update.DIACHI = kh.DIACHI;
                update.EMAIL = kh.EMAIL;
                update.HOTENKH = kh.HOTENKH;
                update.SDT = kh.SDT;
                _db.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteKhachHangByID(int id)
        {
            try
            {
                KHACHHANG del = _db.KHACHHANGs.Where(p => p.ID == id).SingleOrDefault();
                _db.KHACHHANGs.DeleteOnSubmit(del);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertKhachHang(KHACHHANG kh)
        {
            try
            {
                _db.KHACHHANGs.InsertOnSubmit(kh);
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
