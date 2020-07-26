using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_BanVeXe;

namespace GUI_BanVeXe
{
    static class Program
    {

        public static Form_Main formMain = null;
        public static Form_DangNhap formDangNhap = null;
        public static Form_CauHinh formCauHinh = null;
        public static string user = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            formDangNhap = new Form_DangNhap();
            formCauHinh = new Form_CauHinh();


            Application.Run(formDangNhap);
        }
    }
}
