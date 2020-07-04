using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_DatVe
    {
        private int _ID_Ve;
        private string _NgayDat;
        private float _TongTien;
        private int _ID_Chuyen;
        private int _ID_DiaDiemLenXe;
        private string _ID_Ghe;
        private string _HoTenKhachHang;
        private string _Email;
        private string _SDT;
        private string _DiaChi;
        private int _ID_KhachHang;

        public int ID_Ve { get => _ID_Ve; set => _ID_Ve = value; }
        public string NgayDat { get => _NgayDat; set => _NgayDat = value; }
        public float TongTien { get => _TongTien; set => _TongTien = value; }
        public int ID_Chuyen { get => _ID_Chuyen; set => _ID_Chuyen = value; }
        public int ID_DiaDiemLenXe { get => _ID_DiaDiemLenXe; set => _ID_DiaDiemLenXe = value; }
        public string ID_Ghe { get => _ID_Ghe; set => _ID_Ghe = value; }
        public string HoTenKhachHang { get => _HoTenKhachHang; set => _HoTenKhachHang = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public int ID_KhachHang { get => _ID_KhachHang; set => _ID_KhachHang = value; }

        public DTO_DatVe() { }

        public DTO_DatVe(int ID_Ve, string NgayDat, float TongTien, int ID_Chuyen, int ID_DiaDiemLenXe, string ID_Ghe, string HoTenKhachHang, string Email, string SDT,
            string DiaChi, int ID_KhachHang)
        {
            this.ID_Ve = ID_Ve;
            this.NgayDat = NgayDat;
            this.TongTien = TongTien;
            this.ID_Chuyen = ID_Chuyen;
            this.ID_DiaDiemLenXe = ID_DiaDiemLenXe;
            this.ID_Ghe = ID_Ghe;
            this.HoTenKhachHang = HoTenKhachHang;
            this.Email = Email;
            this.SDT = SDT;
            this.DiaChi = DiaChi;
            this.ID_KhachHang = ID_KhachHang;
        }
    }
}
