using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_Xe
    {
        private int _ID_Xe;
        private string _BienSo;
        private string _TrangThai;
        private int _ID_LoaiXe;
        private string _TenLoaiXe;
        private int _SoChoNgoi;

        public int ID_Xe { get => _ID_Xe; set => _ID_Xe = value; }
        public string BienSo { get => _BienSo; set => _BienSo = value; }
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
        public int ID_LoaiXe { get => _ID_LoaiXe; set => _ID_LoaiXe = value; }
        public string TenLoaiXe { get => _TenLoaiXe; set => _TenLoaiXe = value; }
        public int SoChoNgoi { get => _SoChoNgoi; set => _SoChoNgoi = value; }

        public DTO_Xe() { }

        public DTO_Xe(int ID_Xe, string BienSo, string TrangThai, int ID_LoaiXe, string TenLoaiXe, int SoChoNgoi)
        {
            this.ID_Xe = ID_Xe;
            this.BienSo = BienSo;
            this.TrangThai = TrangThai;
            this.ID_LoaiXe = ID_LoaiXe;
            this.TenLoaiXe = TenLoaiXe;
            this.SoChoNgoi = SoChoNgoi;
        }
    }
}
