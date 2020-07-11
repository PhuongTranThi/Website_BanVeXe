using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    
    public class DAL_Ghe
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<XE> LoadXe()
        {
            return _db.XEs.Select(p => p).ToList<XE>();
        }

        public List<LOAIXE> LoadLoaiXe()
        {
            return _db.LOAIXEs.Select(p => p).ToList<LOAIXE>();
        }

        public List<DTO_Ghe> LoadGhe(string bienSo)
        {
            var a = from xe in _db.XEs
                    from lxe in _db.LOAIXEs
                    where xe.ID_LOAIXE == lxe.ID && xe.BIENSO == bienSo
                    select new
                    {
                        ID = xe.ID,
                        ID_LoaiXe = xe.ID_LOAIXE,
                        BienSo = xe.BIENSO,
                        SoChoNgoi = lxe.SOCHONGOI,
                        TrangThai = xe.TRANGTHAI,
                    };
            List<DTO_Ghe> result = a.ToList().ConvertAll(t => new DTO_Ghe
            {
                ID = t.ID,
                ID_LoaiXe = int.Parse(t.ID_LoaiXe.ToString()),
                BienSo = t.BienSo,
                SoChoNgoi = int.Parse(t.SoChoNgoi.ToString()),
                TrangThai = t.TrangThai,
            });
            return result.ToList<DTO_Ghe>();
        }
        //load ghe dax dat
        public List<VE> LoadGheDaDat(int id_chuyen)
        {
            var ghedat = from ve in _db.VEs
                    where ve.ID_CHUYEN == int.Parse(id_chuyen.ToString())
                    select new
                    {
                        id_ghe = ve.ID_GHE,
                    };
            List<VE> result = ghedat.ToList().ConvertAll(t => new VE
            {
                ID_GHE = t.id_ghe,
            });
            return result.ToList<VE>();
        }

        public List<DTO_ChuyenDi> LoadChuyenDi(int tuyendi, string dateStart)
        {
            var a = "2020/06/24";
            if (dateStart != null)
            {
                 a = dateStart.Replace("-", "/").ToString();
                var chuyendi = from chuyen in _db.CHUYENDIs
                               from xe in _db.XEs
                               from loaixe in _db.LOAIXEs
                               where chuyen.ID_TUYENDI == int.Parse(tuyendi.ToString())
                               && chuyen.NGAYKHOIHANH == DateTime.Parse(a)
                               && xe.ID == chuyen.ID_XE
                               && xe.ID_LOAIXE == loaixe.ID
                               select new
                               {
                                   id_chuyen = chuyen.ID,
                                   giodi = chuyen.GIODI,
                                   id_xe = chuyen.ID_XE,
                                   bienso = xe.BIENSO,
                                   id_loaixe = loaixe.ID,
                                   soghe = loaixe.SOCHONGOI,
                               };
                List<DTO_ChuyenDi> result = chuyendi.ToList().ConvertAll(t => new DTO_ChuyenDi
                {
                    ID_Chuyen = t.id_chuyen,
                    GioKhoiHanh = t.giodi.ToString(),
                    ID_Xe = int.Parse(t.id_xe.ToString()),
                    BienSo = t.bienso,
                    ID_LoaiXe = int.Parse(t.id_loaixe.ToString()),
                    SoGhe = int.Parse(t.soghe.ToString()),

                });
                return result.ToList<DTO_ChuyenDi>();
            }
            else
            {
                var chuyendi = from chuyen in _db.CHUYENDIs
                               from xe in _db.XEs
                               from loaixe in _db.LOAIXEs
                               where chuyen.ID_TUYENDI == int.Parse(tuyendi.ToString())
                               && chuyen.NGAYKHOIHANH == DateTime.Parse(a)
                                 && xe.ID == chuyen.ID_XE
                               && xe.ID_LOAIXE == loaixe.ID
                               select new
                               {
                                   id_chuyen = chuyen.ID,
                                   giodi = chuyen.GIODI,
                                   id_xe = chuyen.ID_XE,
                                   bienso = xe.BIENSO,
                                   id_loaixe = loaixe.ID,
                                   soghe = loaixe.SOCHONGOI,
                               };
                List<DTO_ChuyenDi> result = chuyendi.ToList().ConvertAll(t => new DTO_ChuyenDi
                {
                    ID_Chuyen = t.id_chuyen,
                    GioKhoiHanh = t.giodi.ToString(),
                    ID_Xe = int.Parse(t.id_xe.ToString()),
                    BienSo = t.bienso,
                    ID_LoaiXe = int.Parse(t.id_loaixe.ToString()),
                    SoGhe = int.Parse(t.soghe.ToString()),

                });
                return result.ToList<DTO_ChuyenDi>();
            }
           
        }
        public List<DTO_TuyenDi> LoadTuyenDi(int noidi, int noiden)
        {
            var tuyendi = from tuyen in _db.TUYENDIs
                    where tuyen.ID_NOIDI == int.Parse(noidi.ToString())
                    && tuyen.ID_NOIDEN == int.Parse(noiden.ToString())
                          select new
                    {
                        id_tuyen = tuyen.ID,
                        ten_tuyen = tuyen.TENTUYEN,
                        dongia = tuyen.DONGIA,
                        sogiochay = tuyen.SOGIOCHAY,
                        khoangcach = tuyen.KHOANGCACH,
                       
                    };
            List<DTO_TuyenDi> result = tuyendi.ToList().ConvertAll(t => new DTO_TuyenDi
            {
                ID_Tuyen = t.id_tuyen,
                TenTuyen = t.ten_tuyen,
                DonGia = float.Parse(t.dongia.ToString()),
                SoGioChay = float.Parse(t.sogiochay.ToString()),
                KhoangCach = float.Parse(t.khoangcach.ToString()),
            });
            return result.ToList<DTO_TuyenDi>();
        }

        public List<DTO_DiaDiemDon> LoadDiaDiemDon(int tuyendi)
        {
            var diadiem = from ddiem in _db.DIADIEMLENXEs
                          where ddiem.ID_TUYENDI == int.Parse(tuyendi.ToString())
                          select new
                          {
                              id_diadiem = ddiem.ID,
                              ten_diadiem = ddiem.TENDD,

                          };
            List<DTO_DiaDiemDon> result = diadiem.ToList().ConvertAll(t => new DTO_DiaDiemDon
            {
                ID_DiaDiem = t.id_diadiem,
                TenDiaDiem = t.ten_diadiem,
            });
            return result.ToList<DTO_DiaDiemDon>();
        }

    }
}
