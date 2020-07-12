using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_DatVe
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();

        public bool DatVe(DTO_DatVe datve)
        {
            try
            {
                VE ve = new VE();

                ve.NGAYDAT = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                ve.TONGTIEN = datve.TongTien;
                ve.ID_CHUYEN = datve.ID_Chuyen;
                ve.ID_DIADIEMLX = datve.ID_DiaDiemLenXe;
                ve.ID_GHE = datve.ID_Ghe.ToString();
                ve.HOTEN = datve.HoTenKhachHang;
                ve.EMAIL = datve.Email;
                ve.SDT = datve.SDT;
                ve.DIACHI = datve.DiaChi;
                ve.ID_KHACHHANG = datve.ID_KhachHang;

                _db.VEs.InsertOnSubmit(ve);
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
