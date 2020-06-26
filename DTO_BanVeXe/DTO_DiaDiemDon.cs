using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_DiaDiemDon
    {
        private int _ID_DiaDiem;
        private int _ID_TuyenDi;
        private string _TenDiaDiem;

        public int ID_DiaDiem { get => _ID_DiaDiem; set => _ID_DiaDiem = value; }
        public int ID_TuyenDi { get => _ID_TuyenDi; set => _ID_TuyenDi = value; }
        public string TenDiaDiem { get => _TenDiaDiem; set => _TenDiaDiem = value; }

        public DTO_DiaDiemDon() { }

        public DTO_DiaDiemDon(int ID_DiaDiem, int ID_TuyenDi, string TenDiaDiem)
        {

            this.ID_DiaDiem = ID_DiaDiem;
            this.ID_TuyenDi = ID_TuyenDi;
            this.TenDiaDiem = TenDiaDiem;
           
        }
    }
}
