using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_Admin_TuyenDi
    {
        private int _ID_Tuyen;
        private int _ID_NoiDi;
        private int _ID_NoiDen;
        private int _ID_LoaiXe;
        private string _TenTuyen;
        private float _DonGia;
        private float _KhoangCach;
        private float _SoGioChay;

        private string _TenNoiDi;
        private string _TenNoiDen;
        private string _TenLoaiXe;
        private int _SoChoNgoi;

        public int ID_Tuyen { get => _ID_Tuyen; set => _ID_Tuyen = value; }
        public int ID_NoiDi { get => _ID_NoiDi; set => _ID_NoiDi = value; }
        public int ID_NoiDen { get => _ID_NoiDen; set => _ID_NoiDen = value; }
        public int ID_LoaiXe { get => _ID_LoaiXe; set => _ID_LoaiXe = value; }
        public string TenTuyen { get => _TenTuyen; set => _TenTuyen = value; }
        public float DonGia { get => _DonGia; set => _DonGia = value; }
        public float KhoangCach { get => _KhoangCach; set => _KhoangCach = value; }
        public float SoGioChay { get => _SoGioChay; set => _SoGioChay = value; }
        public string TenNoiDi { get => _TenNoiDi; set => _TenNoiDi = value; }
        public string TenNoiDen { get => _TenNoiDen; set => _TenNoiDen = value; }
        public string TenLoaiXe { get => _TenLoaiXe; set => _TenLoaiXe = value; }
        public int SoChoNgoi { get => _SoChoNgoi; set => _SoChoNgoi = value; }

        public DTO_Admin_TuyenDi() { }

        public DTO_Admin_TuyenDi(int ID_Tuyen, int ID_NoiDi, int ID_NoiDen, int ID_LoaiXe, 
            string TenTuyen, float DonGia, float KhoangCach, float SoGioChay, string TenNoiDi, string TenNoiDen, string TenLoaiXe, int SoChoNgoi)
        {

            this.ID_Tuyen = ID_Tuyen;
            this.ID_NoiDi = ID_NoiDi;
            this.ID_NoiDen = ID_NoiDen;
            this.ID_LoaiXe = ID_LoaiXe;
            this.TenTuyen = TenTuyen;
            this.DonGia = DonGia;
            this.KhoangCach = KhoangCach;
            this.SoGioChay = SoGioChay;
            this.TenNoiDi = TenNoiDi;
            this.TenNoiDen = TenNoiDen;
            this.TenLoaiXe = TenLoaiXe;
            this.SoChoNgoi = SoChoNgoi;
        }
    }
}
