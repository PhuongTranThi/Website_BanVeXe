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
    public partial class Form_QuanLyTaiXe : DevExpress.XtraEditors.XtraForm
    {
        public Form_QuanLyTaiXe()
        {
            InitializeComponent();
        }
        DAL_Winform_TaiXe dal_QuanLyTaiXe = new DAL_Winform_TaiXe();
        TAIXE taixe = new TAIXE();
        DAL_Winform_LoaiNhanVien loainhanvien = new DAL_Winform_LoaiNhanVien();

        void LoadDanhSachNhanVien()
        {
            grcNhanVien.DataSource = dal_QuanLyTaiXe.LoadTaiXe();

            lookLoaiNhanVienn.DataSource = loainhanvien.LoadLoaiNhanVien();
            lookLoaiNhanVienn.DisplayMember = "TENLOAINV";
            lookLoaiNhanVienn.ValueMember = "ID";

            ColumnLoaiNhanVien.ColumnEdit = lookLoaiNhanVienn;
        }
        private void Form_QuanLyTaiXe_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void grvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaTX.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "ID");
            txtTenTX.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "HOTENTX");
            txtDiaChi.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "DIACHI");
            dateNgaySinh.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "NGAYSINH");
            txtSDT.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "SDT");
            cbbGioiTinh.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "GIOITINH");
            //lookLoaiNhanVien.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "TenLoaiNhanVien");
            
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // nhanvien = new NHANVIEN();
                if (string.IsNullOrEmpty(txtTenTX.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống", "Thông báo");
                    this.txtTenTX.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(dateNgaySinh.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống", "Thông báo");
                    this.dateNgaySinh.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtDiaChi.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống", "Thông báo");
                    this.txtDiaChi.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtSDT.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống", "Thông báo");
                    this.txtSDT.Focus();
                    return;
                }
                taixe.HOTENTX = txtTenTX.Text;
                taixe.GIOITINH = cbbGioiTinh.Text;
                taixe.NGAYSINH = DateTime.Parse(dateNgaySinh.Text.ToString());
                taixe.SDT = txtSDT.Text;
                taixe.DIACHI = txtDiaChi.Text;
                taixe.ID_LOAINV = 2;
                if (dal_QuanLyTaiXe.ThemTaiXe(taixe) == true)
                {
                    XtraMessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công!", "Thông báo");
                }
                LoadDanhSachNhanVien();
            }
            catch {
                XtraMessageBox.Show("Lỗi!", "Thông báo");
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenTX.Text = "";
            dateNgaySinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtMaTX.Text = "";
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn chắc chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    taixe.ID = int.Parse(txtMaTX.Text);
                    dal_QuanLyTaiXe.XoaTaiXe(taixe);
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadDanhSachNhanVien();
                }
            }
            catch { XtraMessageBox.Show("Lỗi!", "Thông báo"); }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                taixe.ID = int.Parse(txtMaTX.Text);
                taixe.HOTENTX = txtTenTX.Text;
                taixe.GIOITINH = cbbGioiTinh.Text;
                taixe.NGAYSINH = DateTime.Parse(dateNgaySinh.Text.ToString());
                taixe.SDT = txtSDT.Text;
                taixe.DIACHI = txtDiaChi.Text;
                taixe.ID_LOAINV = 2;
                dal_QuanLyTaiXe.SuaTaiXe(taixe);
                XtraMessageBox.Show("Sửa thành công!", "Thông báo");
                LoadDanhSachNhanVien();
            }
            catch { XtraMessageBox.Show("Lỗi!", "Thông báo"); }
        }
    }
}