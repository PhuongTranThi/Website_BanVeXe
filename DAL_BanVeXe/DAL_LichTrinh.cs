using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_LichTrinh
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<DTO_LichTrinh> LoadLichTrinh()
        {
            var lichtrinh = from tuyen in _db.TUYENDIs
                          from ndi in _db.NOIDIs
                          from nden in _db.NOIDENs
                          from loaixe in _db.LOAIXEs
                          where tuyen.ID_NOIDI == ndi.ID
                          && tuyen.ID_NOIDEN == nden.ID
                          && tuyen.ID_LOAIXE == loaixe.ID

                          select new
                          {
                              ten_noidi = ndi.TENNOIDI,
                              ten_noiden = nden.TENNOIDEN,
                              ten_loaixe = loaixe.TENLOAIXE,
                              khoangcach = tuyen.KHOANGCACH,
                              sogiochay = tuyen.SOGIOCHAY,
                              dongia = tuyen.DONGIA,
                              
                          };
            List<DTO_LichTrinh> result = lichtrinh.ToList().ConvertAll(t => new DTO_LichTrinh
            {
                TenNoiDi = t.ten_noidi,
                TenNoiDen = t.ten_noiden,
                TenLoaiXe = t.ten_loaixe,
                DonGia = float.Parse(t.dongia.ToString()),
                SoGioChay = float.Parse(t.sogiochay.ToString()),
                KhoangCach = float.Parse(t.khoangcach.ToString()),
            });
            return result.ToList<DTO_LichTrinh>();
        }
    }
}
