using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_NhanVien
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<DTO_TaiXe> LoadTaiXe()
        {
            var phuong = from taixe in _db.TAIXEs
                            from loainv in _db.LOAINHANVIENs
                            where taixe.ID_LOAINV == loainv.ID
                            select new
                            {
                                id_TX = taixe.ID,
                                tenTX = taixe.HOTENTX,
                                ngaysinhTX = taixe.NGAYSINH,
                                gioitinhTX = taixe.GIOITINH,
                                sdtTX = taixe.SDT,
                                diachiTX = taixe.DIACHI,
                                id_LoaiNV = loainv.ID,
                                ten_loaiNV = loainv.TENLOAINV
                            };
            List<DTO_TaiXe> result = phuong.ToList().ConvertAll(t => new DTO_TaiXe
            {
                ID_TaiXe = t.id_TX,
                HoTenTX = t.tenTX,
                NgaySinhTX = t.ngaysinhTX.ToString(),
                GioiTinhTX = t.gioitinhTX,
                SDTTX = t.sdtTX,
                DiaChiTX = t.diachiTX,
                ID_LoaiNhanVien = t.id_LoaiNV,
                TenLoaiNhanVien = t.ten_loaiNV
               
            });
            return result.ToList<DTO_TaiXe>();
        }

        public List<DTO_PhuXe> LoadPhuXe()
        {
            var phuxene = from phuxe in _db.PHUXEs
                         from loainv in _db.LOAINHANVIENs
                         where phuxe.ID_LOAINV == loainv.ID
                         select new
                         {
                             id_PX = phuxe.ID,
                             tenPX = phuxe.HOTENPX,
                             ngaysinhPX = phuxe.NGAYSINH,
                             gioitinhPX = phuxe.GIOITINH,
                             sdtPX = phuxe.SDT,
                             diachiPX = phuxe.DIACHI,
                             id_LoaiNV = loainv.ID,
                             ten_loaiNV = loainv.TENLOAINV
                         };
            List<DTO_PhuXe> result = phuxene.ToList().ConvertAll(t => new DTO_PhuXe
            {
                ID_PhuXe = t.id_PX,
                HoTenPX = t.tenPX,
                NgaySinhPX = t.ngaysinhPX.ToString(),
                GioiTinhPX = t.gioitinhPX,
                SDTPX = t.sdtPX,
                DiaChiPX = t.diachiPX,
                ID_LoaiNhanVien = t.id_LoaiNV,
                TenLoaiNhanVien = t.ten_loaiNV

            });
            return result.ToList<DTO_PhuXe>();
        }

        public List<DTO_NhanVienBanVe> LoadNhanVienBanVe()
        {
            var nvbanve = from nv in _db.NHANVIENs
                          from loainv in _db.LOAINHANVIENs
                          where nv.ID_LOAINV == loainv.ID
                          select new
                          {
                              id_NV = nv.ID,
                              tenNV = nv.HOTENNV,
                              ngaysinhNV = nv.NGAYSINH,
                              gioitinhNV = nv.GIOITINH,
                              sdtNV = nv.SDT,
                              diachiNV = nv.DIACHI,
                              id_LoaiNV = loainv.ID,
                              ten_loaiNV = loainv.TENLOAINV
                          };
            List<DTO_NhanVienBanVe> result = nvbanve.ToList().ConvertAll(t => new DTO_NhanVienBanVe
            {
                ID_NVBanVe = t.id_NV,
                HoTenNVBV = t.tenNV,
                NgaySinhNVBV = t.ngaysinhNV.ToString(),
                GioiTinhNVBV = t.gioitinhNV,
                SDTNVBV = t.sdtNV,
                DiaChiNVBV = t.diachiNV,
                ID_LoaiNhanVien = t.id_LoaiNV,
                TenLoaiNhanVien = t.ten_loaiNV

            });
            return result.ToList<DTO_NhanVienBanVe>();
        }
    }
}
