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
                        idLoai = kh.ID_LoaiNguoiDung,
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
                ID_LoaiNguoiDung = t.idLoai,
                CMND = t.cmnd
            });
            return kq.ToList<KHACHHANG>()[0];
        }
    }
}
