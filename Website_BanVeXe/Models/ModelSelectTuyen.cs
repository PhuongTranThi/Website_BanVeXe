using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website_BanVeXe.Models
{
    public class ModelSelectTuyen
    {
        private string _noidi;
        private string _noiden;
        private string _ngaydi;
        public string Noidi { get => _noidi; set => _noidi = value; }
        public string Noiden { get => _noiden; set => _noiden = value; }
        public string Ngaydi { get => _ngaydi; set => _ngaydi = value; }
        public ModelSelectTuyen() { }
        public ModelSelectTuyen(string noidi, string noiden, string date) {
            this.Ngaydi = date;
            this.Noiden = noiden;
            this.Noidi = noidi;
        }

    }
}