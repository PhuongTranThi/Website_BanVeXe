using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_PhuXe
    {
        private int _ID_PhuXe;
        private string _HoTenPX;
        private string _NgaySinhPX;
        private string _GioiTinhPX;
        private string _SDTPX;
        private string _DiaChiPX;
        private int _ID_LoaiNhanVien;
        private string _TenLoaiNhanVien;

        public int ID_PhuXe { get => _ID_PhuXe; set => _ID_PhuXe = value; }
        public string HoTenPX { get => _HoTenPX; set => _HoTenPX = value; }
        public string NgaySinhPX { get => _NgaySinhPX; set => _NgaySinhPX = value; }
        public string GioiTinhPX { get => _GioiTinhPX; set => _GioiTinhPX = value; }
        public string SDTPX { get => _SDTPX; set => _SDTPX = value; }
        public string DiaChiPX { get => _DiaChiPX; set => _DiaChiPX = value; }
        public int ID_LoaiNhanVien { get => _ID_LoaiNhanVien; set => _ID_LoaiNhanVien = value; }
        public string TenLoaiNhanVien { get => _TenLoaiNhanVien; set => _TenLoaiNhanVien = value; }

        public DTO_PhuXe() { }

        public DTO_PhuXe(int ID_PhuXe, string HoTenPX, string NgaySinhPX, string GioiTinhPX, string SDTPX, string DiaChiPX, int ID_LoaiNhanVien, string TenLoaiNhanVien)
        {
            this.DiaChiPX = DiaChiPX;
            this.GioiTinhPX = GioiTinhPX;
            this.HoTenPX = HoTenPX;
            this.ID_PhuXe = ID_PhuXe;
            this.NgaySinhPX = NgaySinhPX;
            this.SDTPX = SDTPX;
            this.ID_LoaiNhanVien = ID_LoaiNhanVien;
            this.TenLoaiNhanVien = TenLoaiNhanVien;
        }
    }
}
