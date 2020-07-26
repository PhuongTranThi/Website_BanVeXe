using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL_BanVeXe;

namespace GUI_BanVeXe
{
    public partial class Form_PhanQuyen : DevExpress.XtraEditors.XtraForm
    {
        public Form_PhanQuyen()
        {
            InitializeComponent();
        }
        DAL_Winform_PhanQuyen dal_phanquyen = new DAL_Winform_PhanQuyen();

        void LoadDSNhomNguoiDung()
        {
            grcNhomNguoiDung.DataSource = dal_phanquyen.LoadNhomNguoiDung();
        }
        void LoadDSPhanQuyen()
        {
            grcPhanQuyen.DataSource = dal_phanquyen.LoadPhanQuyen();

            lookManHinh.DataSource = dal_phanquyen.LoadManHinh();
            lookManHinh.DisplayMember = "TENMANHINH";
            lookManHinh.ValueMember = "MAMANHINH";

            ClumnManHinh.ColumnEdit = lookManHinh;
        }   

        private void Form_PhanQuyen_Load(object sender, EventArgs e)
        {
            LoadDSNhomNguoiDung();
            LoadDSPhanQuyen();
        }
    }
}