using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_ChuyenDi
    {
       
        private int _ID_Chuyen;
        private string _NgayKhoiHanh;
        private string _GioKhoiHanh;
        private int _ID_Tuyen;
        private string _TenTuyen;
        private int _ID_Xe;

        private string _BienSo;
        private int _ID_LoaiXe;
        private int _SoGhe;

        public int ID_Chuyen { get => _ID_Chuyen; set => _ID_Chuyen = value; }
        public string NgayKhoiHanh { get => _NgayKhoiHanh; set => _NgayKhoiHanh = value; }
        public string GioKhoiHanh { get => _GioKhoiHanh; set => _GioKhoiHanh = value; }
        public int ID_Tuyen { get => _ID_Tuyen; set => _ID_Tuyen = value; }
        public int ID_Xe { get => _ID_Xe; set => _ID_Xe = value; }
        public string BienSo { get => _BienSo; set => _BienSo = value; }
        public int ID_LoaiXe { get => _ID_LoaiXe; set => _ID_LoaiXe = value; }
        public int SoGhe { get => _SoGhe; set => _SoGhe = value; }
        public string TenTuyen { get => _TenTuyen; set => _TenTuyen = value; }

        public DTO_ChuyenDi() { }

        public DTO_ChuyenDi(int ID_Chuyen, string NgayKhoiHanh, string GioKhoiHanh, int ID_Tuyen, int ID_Xe, string BienSo, int ID_LoaiXe, int SoGhe, string TenTuyen)
        {
            this.ID_Chuyen = ID_Chuyen;
            this.NgayKhoiHanh = NgayKhoiHanh;
            this.GioKhoiHanh = GioKhoiHanh;
            this.ID_Tuyen = ID_Tuyen;
            this.ID_Xe = ID_Xe;
            this.BienSo = BienSo;
            this.ID_LoaiXe = ID_LoaiXe;
            this.SoGhe = SoGhe;
            this.TenTuyen = TenTuyen;
        }
    }
}
