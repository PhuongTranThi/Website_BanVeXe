using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_Admin_ChuyenDi
    {
        private int _ID_ChuyenDi;
        private int _ID_TuyenDi;
        private int _ID_Xe;
        private int _ID_TaiXe;
        private int _ID_PhuXe;
        private string _NgayKhoiHanh;
        private string _GioDi;
        
        private string _TenTuyenDi;
        private string _BienSoXe;

        private string _TenTaiXe;

        private string _TenPhuXe;

        public int ID_ChuyenDi { get => _ID_ChuyenDi; set => _ID_ChuyenDi = value; }
        public int ID_TuyenDi { get => _ID_TuyenDi; set => _ID_TuyenDi = value; }
        public int ID_Xe { get => _ID_Xe; set => _ID_Xe = value; }
        public int ID_TaiXe { get => _ID_TaiXe; set => _ID_TaiXe = value; }
        public int ID_PhuXe { get => _ID_PhuXe; set => _ID_PhuXe = value; }
        public string NgayKhoiHanh { get => _NgayKhoiHanh; set => _NgayKhoiHanh = value; }
        public string GioDi { get => _GioDi; set => _GioDi = value; }
        public string TenTuyenDi { get => _TenTuyenDi; set => _TenTuyenDi = value; }
        public string BienSoXe { get => _BienSoXe; set => _BienSoXe = value; }
        public string TenTaiXe { get => _TenTaiXe; set => _TenTaiXe = value; }
        public string TenPhuXe { get => _TenPhuXe; set => _TenPhuXe = value; }


        public DTO_Admin_ChuyenDi() { }

        public DTO_Admin_ChuyenDi(int ID_ChuyenDi, int ID_TuyenDi, int ID_Xe, int ID_TaiXe,  int ID_PhuXe, string NgayKhoiHanh,
            string GioDi, string TenTuyenDi, string BienSoXe, string TenTaiXe, string TenPhuXe)
        {
            this.ID_TuyenDi = ID_TuyenDi;
            this.ID_ChuyenDi = ID_ChuyenDi;
            this.ID_Xe = ID_Xe;
            this.TenTaiXe = TenTaiXe;
            this.ID_PhuXe = ID_PhuXe;
            this.NgayKhoiHanh = NgayKhoiHanh;
            this.GioDi = GioDi;
            this.TenTuyenDi = TenTuyenDi;
            this.BienSoXe = BienSoXe;
            this.ID_TaiXe = ID_TaiXe;
            this.TenPhuXe = TenPhuXe;
            
        }
    }
}
