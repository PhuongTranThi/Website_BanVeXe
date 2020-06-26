using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_Ghe
    {
        private int _ID;
        private int _ID_LoaiXe;
        private string _BienSo;
        private string _TrangThai;
        private int _SoChoNgoi;
        

        public string BienSo { get => _BienSo; set => _BienSo = value; }
        public string TrangThai { get => _TrangThai; set => _TrangThai = value; }
        public int SoChoNgoi { get => _SoChoNgoi; set => _SoChoNgoi = value; }
        public int ID { get => _ID; set => _ID = value; }
        public int ID_LoaiXe { get => _ID_LoaiXe; set => _ID_LoaiXe = value; }

        public DTO_Ghe() { }
        public DTO_Ghe(int ID, int ID_LoaiXe, string BienSo, int SoChoNgoi, string TrangThai)
        {
            this.ID = ID;
            this.ID_LoaiXe = ID_LoaiXe;
            this.BienSo = BienSo;
            this.SoChoNgoi = SoChoNgoi;
            this.TrangThai = TrangThai;
        }
    }
}
