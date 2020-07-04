using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_DangKy
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();

        public bool DangKy(DTO_DangKy a)
        {
            try
            {
                KHACHHANG khachhang = new KHACHHANG();

                khachhang.HOTENKH = a.HoTen;
                khachhang.EMAIL = a.Email;
                khachhang.SDT = a.SDT;
                khachhang.CMND = a.CMND;
                khachhang.DIACHI = a.DiaChi;
                khachhang.PASSWORD = a.Pass;

                _db.KHACHHANGs.InsertOnSubmit(khachhang);
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
