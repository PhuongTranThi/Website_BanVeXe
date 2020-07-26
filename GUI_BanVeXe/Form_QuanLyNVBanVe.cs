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
    public partial class Form_QuanLyNVBanVe : DevExpress.XtraEditors.XtraForm
    {
        public Form_QuanLyNVBanVe()
        {
            InitializeComponent();
        }
        DAL_Winform_NVBanVe dal_QuanLyNVBanVe = new DAL_Winform_NVBanVe();
        PHUXE phuxe = new PHUXE();
        DAL_Winform_LoaiNhanVien loainhanvien = new DAL_Winform_LoaiNhanVien();

        void LoadDanhSachNhanVien()
        {
            grcNhanVien.DataSource = dal_QuanLyNVBanVe.Loadnvbv();

            lookLoaiNhanVienn.DataSource = loainhanvien.LoadLoaiNhanVien();
            lookLoaiNhanVienn.DisplayMember = "TENLOAINV";
            lookLoaiNhanVienn.ValueMember = "ID";

            ColumnLoaiNhanVien.ColumnEdit = lookLoaiNhanVienn;
        }
        private void Form_QuanLyNVBanVe_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void grvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaNVBanVe.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "ID");
            txtTenNVBanVe.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "HOTENNV");
            txtDiaChi.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "DIACHI");
            dateNgaySinh.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "NGAYSINH");
            txtSDT.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "SDT");
            cbbGioiTinh.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "GIOITINH");
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}