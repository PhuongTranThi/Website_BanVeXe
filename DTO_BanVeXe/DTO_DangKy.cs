using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_BanVeXe
{
    public class DTO_DangKy
    {
        private string _HoTen;
        private string _Email;
        private string _SDT;
        private string _CMND;
        private string _ConfirmPass;
        private string _Pass;
        private string _DiaChi;

        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string CMND { get => _CMND; set => _CMND = value; }
        public string Pass { get => _Pass; set => _Pass = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string ConfirmPass { get => _ConfirmPass; set => _ConfirmPass = value; }

        public DTO_DangKy() { }

        public DTO_DangKy(string HoTen, string Email, string SDT, string CMND, string Pass, string DiaChi, string ConfirmPass)
        {
            this.HoTen = HoTen;
            this.Email = Email;
            this.SDT = SDT;
            this.CMND = CMND;
            this.Pass = Pass;
            this.DiaChi = DiaChi;
            this.ConfirmPass = ConfirmPass;

        }
    }
}
