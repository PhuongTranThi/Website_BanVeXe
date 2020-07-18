using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_TaiXe
    {
        private int _ID_TaiXe;
        private string _HoTenTX;
        private string _NgaySinhTX;
        private string _GioiTinhTX;
        private string _SDTTX;
        private string _DiaChiTX;
        private int _ID_LoaiNhanVien;
        private string _TenLoaiNhanVien;

        public int ID_TaiXe { get => _ID_TaiXe; set => _ID_TaiXe = value; }
        public string HoTenTX { get => _HoTenTX; set => _HoTenTX = value; }
        public string NgaySinhTX { get => _NgaySinhTX; set => _NgaySinhTX = value; }
        public string GioiTinhTX { get => _GioiTinhTX; set => _GioiTinhTX = value; }
        public string SDTTX { get => _SDTTX; set => _SDTTX = value; }
        public string DiaChiTX { get => _DiaChiTX; set => _DiaChiTX = value; }
        public int ID_LoaiNhanVien { get => _ID_LoaiNhanVien; set => _ID_LoaiNhanVien = value; }
        public string TenLoaiNhanVien { get => _TenLoaiNhanVien; set => _TenLoaiNhanVien = value; }

        public DTO_TaiXe() { }

        public DTO_TaiXe(int ID_TaiXe, string HoTenTX, string NgaySinhTX, string GioiTinhTX, string SDTTX, string DiaChiTX, int ID_LoaiNhanVien, string TenLoaiNhanVien)
        {
            this.DiaChiTX = DiaChiTX;
            this.GioiTinhTX = GioiTinhTX;
            this.HoTenTX = HoTenTX;
            this.ID_TaiXe = ID_TaiXe;
            this.NgaySinhTX = NgaySinhTX;
            this.SDTTX = SDTTX;
            this.ID_LoaiNhanVien = ID_LoaiNhanVien;
            this.TenLoaiNhanVien = TenLoaiNhanVien;
        }
    }
}
