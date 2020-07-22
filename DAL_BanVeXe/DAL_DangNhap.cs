using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_DangNhap
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();

        public bool DangNhap(string email, string pass)
        {
            return _db.KHACHHANGs.Any(p => p.EMAIL == email && p.PASSWORD == pass);
        }
        public KHACHHANG SS_DangNhap(string email, string pass)
        {
            var a = from kh in _db.KHACHHANGs
         
                    where kh.EMAIL == email && kh.PASSWORD == pass
                    select new
                    {
                        id= kh.ID,
                        tenkh = kh.HOTENKH,
                        sdt = kh.SDT,
                        email = kh.EMAIL,
                        password = kh.PASSWORD,
                        diachi = kh.DIACHI,
                        cmnd = kh.CMND
                    };
            var kq = a.ToList().ConvertAll(t => new KHACHHANG
            {
                ID = t.id,
                HOTENKH = t.tenkh,
                SDT = t.sdt,
                EMAIL = t.email,
                PASSWORD = t.password,
                DIACHI = t.diachi,
                CMND = t.cmnd
            });
            return kq.ToList<KHACHHANG>()[0];
        }

        //========================================
        public bool getDangNhap(string user, string pass)
        {
            return _db.USERs.Any(p => p.USERNAME == user && p.PASSWORD == pass);
        }
        public USER DangNhapAdmin(string user, string pass)
        {
            var phuong = from ad in _db.USERs

                    where ad.USERNAME == user && ad.PASSWORD == pass
                    select new
                    {
                        id = ad.ID,
                        user = ad.USERNAME,
                        password = ad.PASSWORD,
                        id_loainguoidung = ad.ID_LOAINGUOIDUNG
                        
                    };
            var kq = phuong.ToList().ConvertAll(t => new USER
            {
                ID = t.id,
                USERNAME = t.user,
                PASSWORD = t.password,
                ID_LOAINGUOIDUNG = t.id_loainguoidung
            });
            return kq.ToList<USER>()[0];
        }
    }
}
