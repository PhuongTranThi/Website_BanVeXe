using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_NhanVienBanVe
    {
        private int _ID_NVBanVe;
        private string _HoTenNVBV;
        private string _NgaySinhNVBV;
        private string _GioiTinhNVBV;
        private string _SDTNVBV;
        private string _DiaChiNVBV;

        private int _ID_LoaiNhanVien;
        private string _TenLoaiNhanVien;

        public int ID_NVBanVe { get => _ID_NVBanVe; set => _ID_NVBanVe = value; }
        public string HoTenNVBV { get => _HoTenNVBV; set => _HoTenNVBV = value; }
        public string NgaySinhNVBV { get => _NgaySinhNVBV; set => _NgaySinhNVBV = value; }
        public string GioiTinhNVBV { get => _GioiTinhNVBV; set => _GioiTinhNVBV = value; }
        public string SDTNVBV { get => _SDTNVBV; set => _SDTNVBV = value; }
        public string DiaChiNVBV { get => _DiaChiNVBV; set => _DiaChiNVBV = value; }
        public int ID_LoaiNhanVien { get => _ID_LoaiNhanVien; set => _ID_LoaiNhanVien = value; }
        public string TenLoaiNhanVien { get => _TenLoaiNhanVien; set => _TenLoaiNhanVien = value; }

        public DTO_NhanVienBanVe() { }

        public DTO_NhanVienBanVe(int ID_NVBanVe, string HoTenNVBV, string NgaySinhNVBV, string GioiTinhNVBV, string SDTNVBV, string DiaChiNVBV, int ID_LoaiNhanVien, string TenLoaiNhanVien)
        {
            this.DiaChiNVBV = DiaChiNVBV;
            this.GioiTinhNVBV = GioiTinhNVBV;
            this.HoTenNVBV = HoTenNVBV;
            this.ID_NVBanVe = ID_NVBanVe;
            this.NgaySinhNVBV = NgaySinhNVBV;
            this.SDTNVBV = SDTNVBV;
            this.ID_LoaiNhanVien = ID_LoaiNhanVien;
            this.TenLoaiNhanVien = TenLoaiNhanVien;
        }
    }
}
