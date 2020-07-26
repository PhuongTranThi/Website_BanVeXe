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
    public partial class Form_QuanLyTuyenDi : DevExpress.XtraEditors.XtraForm
    {
        public Form_QuanLyTuyenDi()
        {
            InitializeComponent();
        }
        DAL_Winform_TuyenDi dal_QuanLyTuyenDi = new DAL_Winform_TuyenDi();
        TUYENDI tuyendi = new TUYENDI();
        DAL_Winfrom_NoiDi noidi = new DAL_Winfrom_NoiDi();
        DAL_Winform_NoiDen noiden = new DAL_Winform_NoiDen();
        DAL_Winform_LoaiXe loaixe = new DAL_Winform_LoaiXe();

        void LoadDanhSachTuyenDi()
        {
            grcTuyenDi.DataSource = dal_QuanLyTuyenDi.LoadTuyenDi();

            lookBenDi2.DataSource = noidi.LoadNoiDi();
            lookBenDi2.DisplayMember = "TENNOIDI";
            lookBenDi2.ValueMember = "ID";

            ColumnBenDi.ColumnEdit = lookBenDi2;

            lookBenDen2.DataSource = noiden.LoadNoiDen();
            lookBenDen2.DisplayMember = "TENNOIDEN";
            lookBenDen2.ValueMember = "ID";

            ColumnBenDen.ColumnEdit = lookBenDen2;

            lookLoaiXe2.DataSource = loaixe.LoadLoaiXe();
            lookLoaiXe2.DisplayMember = "TENLOAIXE";
            lookLoaiXe2.ValueMember = "ID";

            ColIDLoaiXe.ColumnEdit = lookLoaiXe2;
        }
        private void Form_QuanLyTuyenDi_Load(object sender, EventArgs e)
        {
            lookNoiDen.Properties.DataSource = noiden.LoadNoiDen();
            lookNoiDen.Properties.DisplayMember = "TENNOIDEN";
            lookNoiDen.Properties.ValueMember = "ID";
            lookNoiDen.Properties.NullText = "@Chọn nơi đến";

            lookNoiDi.Properties.DataSource = noidi.LoadNoiDi();
            lookNoiDi.Properties.DisplayMember = "TENNOIDI";
            lookNoiDi.Properties.ValueMember = "ID";
            lookNoiDi.Properties.NullText = "@Chọn nơi đi";

            lookLoaiXe.Properties.DataSource = loaixe.LoadLoaiXe();
            lookLoaiXe.Properties.DisplayMember = "TENLOAIXE";
            lookLoaiXe.Properties.ValueMember = "ID";
            lookLoaiXe.Properties.NullText = "@Chọn loại xe";

            LoadDanhSachTuyenDi();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenTuyenDi.Text = "";
            txtDonGia.Text = "";
            txtKhoangCach.Text = "";
            txtMaTuyenDi.Text = "";
            txtSoGioChay.Text = "";
            
        }

        private void brnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTenTuyenDi.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống", "Thông báo");
                    this.txtTenTuyenDi.Focus();
                    return;
                }
                tuyendi.DONGIA = float.Parse(txtDonGia.Text.ToString());
                tuyendi.KHOANGCACH = float.Parse(txtKhoangCach.Text.ToString());
                tuyendi.SOGIOCHAY = float.Parse(txtSoGioChay.Text.ToString());
                tuyendi.TENTUYEN = txtTenTuyenDi.Text;
                tuyendi.ID_NOIDEN = int.Parse(lookNoiDen.EditValue.ToString());
                tuyendi.ID_NOIDI = int.Parse(lookNoiDi.EditValue.ToString());
                tuyendi.ID_LOAIXE = int.Parse(lookLoaiXe.EditValue.ToString());
                if (dal_QuanLyTuyenDi.ThemTuyenDi(tuyendi) == true)
                {
                    XtraMessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công!", "Thông báo");
                }
                LoadDanhSachTuyenDi();
            }
            catch { XtraMessageBox.Show("Lỗi!", "Thông báo"); }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn chắc chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    tuyendi.ID = int.Parse(txtMaTuyenDi.Text);
                    dal_QuanLyTuyenDi.XoaTuyenDi(tuyendi);
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadDanhSachTuyenDi();
                }
            }
            catch { XtraMessageBox.Show("Lỗi!", "Thông báo"); }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                tuyendi.DONGIA = float.Parse(txtDonGia.Text.ToString());
                tuyendi.KHOANGCACH = float.Parse(txtKhoangCach.Text.ToString());
                tuyendi.SOGIOCHAY = float.Parse(txtSoGioChay.Text.ToString());
                tuyendi.TENTUYEN = txtTenTuyenDi.Text;
                tuyendi.ID_NOIDEN = int.Parse(lookNoiDen.EditValue.ToString());
                tuyendi.ID_NOIDI = int.Parse(lookNoiDi.EditValue.ToString());
                tuyendi.ID_LOAIXE = int.Parse(lookLoaiXe.EditValue.ToString());
                dal_QuanLyTuyenDi.SuaTuyenDi(tuyendi);
                XtraMessageBox.Show("Sua thành công!", "Thông báo");
                LoadDanhSachTuyenDi();
            }
            catch { XtraMessageBox.Show("Lỗi!", "Thông báo"); }
        }

        private void grvTuyenDi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaTuyenDi.EditValue = grvTuyenDi.GetRowCellValue(e.FocusedRowHandle, "ID");
            txtTenTuyenDi.EditValue = grvTuyenDi.GetRowCellValue(e.FocusedRowHandle, "TENTUYEN");
            txtDonGia.EditValue = grvTuyenDi.GetRowCellValue(e.FocusedRowHandle, "DONGIA");
            txtKhoangCach.EditValue = grvTuyenDi.GetRowCellValue(e.FocusedRowHandle, "KHOANGCACH");
            txtSoGioChay.EditValue = grvTuyenDi.GetRowCellValue(e.FocusedRowHandle, "SOGIOCHAY");
            lookNoiDi.EditValue = grvTuyenDi.GetRowCellValue(e.FocusedRowHandle, "ID_NOIDI");
            lookNoiDen.EditValue = grvTuyenDi.GetRowCellValue(e.FocusedRowHandle, "ID_NOIDEN");
            lookLoaiXe.EditValue = grvTuyenDi.GetRowCellValue(e.FocusedRowHandle, "ID_LOAIXE");
        }
    }
}