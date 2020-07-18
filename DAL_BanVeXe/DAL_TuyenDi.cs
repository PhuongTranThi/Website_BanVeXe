using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_TuyenDi
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        TUYENDI _tuyendi = new TUYENDI();
        NOIDI _noidi = new NOIDI();
        NOIDEN _noiden = new NOIDEN();

        public List<TUYENDI> LoadTuyenDi()
        {
            return _db.TUYENDIs.Select(p => p).ToList<TUYENDI>();

        }
        public List<NOIDI> LoadNoiDi()
        {
            return _db.NOIDIs.Select(p => p).ToList<NOIDI>();

        }
        public List<NOIDEN> LoadNoiDen()
        {
            return _db.NOIDENs.Select(p => p).ToList<NOIDEN>();
           

        }
        public List<DTO_Admin_TuyenDi> LoadTuyenDiAdmin()
        {
            var phuong = from tuyen in _db.TUYENDIs
                         from noidi in _db.NOIDIs
                         from noiden in _db.NOIDENs
                         from loaixe in _db.LOAIXEs
                         where tuyen.ID_LOAIXE == loaixe.ID
                         && tuyen.ID_NOIDI == noidi.ID
                         && tuyen.ID_NOIDEN == noiden.ID
                         select new
                         {
                             id_tuyen = tuyen.ID,
                             id_noidi = tuyen.ID_NOIDI,
                             id_noiden = tuyen.ID_NOIDEN,
                             id_loaixe = tuyen.ID_LOAIXE,
                             tentuyen = tuyen.TENTUYEN,
                             dongia = tuyen.DONGIA,
                             khoangcach = tuyen.KHOANGCACH,
                             sogiochay = tuyen.SOGIOCHAY,
                             tennoidi = noidi.TENNOIDI,
                             tennoiden = noiden.TENNOIDEN,
                             tenloaixe = loaixe.TENLOAIXE,
                             sochongoi = loaixe.SOCHONGOI,
                            
                         };
            List<DTO_Admin_TuyenDi> result = phuong.ToList().ConvertAll(t => new DTO_Admin_TuyenDi
            {
                ID_Tuyen = t.id_tuyen,
                ID_NoiDi = int.Parse(t.id_noidi.ToString()),
                ID_NoiDen = int.Parse(t.id_noiden.ToString()),
                ID_LoaiXe = int.Parse(t.id_loaixe.ToString()),
                TenTuyen = t.tentuyen,
                DonGia = float.Parse(t.dongia.ToString()),
                KhoangCach = float.Parse(t.khoangcach.ToString()),
                SoChoNgoi = int.Parse(t.sochongoi.ToString()),
                SoGioChay = float.Parse(t.sogiochay.ToString()),
                TenNoiDi = t.tennoidi,
                TenNoiDen = t.tennoiden,
                TenLoaiXe = t.tenloaixe
              

            });
            return result.ToList<DTO_Admin_TuyenDi>();
        }


    }
}
