using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DTO_BanVeXe
{
    public class DTO_NoiDi
    {
        private string _MaNoiDi;
        private string _TenNoiDi;

        public string MaNoiDi { get => _MaNoiDi; set => _MaNoiDi = value; }
        public string TenNoiDi { get => _TenNoiDi; set => _TenNoiDi = value; }
        public DTO_NoiDi()
        {

        }
        public DTO_NoiDi(string MaNoiDi, string TenNoiDi)
        {
            this.MaNoiDi = MaNoiDi;
            this.TenNoiDi = TenNoiDi;
        }
    }
}
