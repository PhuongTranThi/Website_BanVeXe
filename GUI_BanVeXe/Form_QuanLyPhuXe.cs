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
    public partial class Form_QuanLyPhuXe : DevExpress.XtraEditors.XtraForm
    {
        public Form_QuanLyPhuXe()
        {
            InitializeComponent();
        }
        DAL_Winform_PhuXe dal_QuanLyPhuXe = new DAL_Winform_PhuXe();
        PHUXE phuxe = new PHUXE();
        DAL_Winform_LoaiNhanVien loainhanvien = new DAL_Winform_LoaiNhanVien();


        void LoadDanhSachNhanVien()
        {
            grcNhanVien.DataSource = dal_QuanLyPhuXe.Loadphuxe();

            lookLoaiNhanVienn.DataSource = loainhanvien.LoadLoaiNhanVien();
            lookLoaiNhanVienn.DisplayMember = "TENLOAINV";
            lookLoaiNhanVienn.ValueMember = "ID";

            ColumnLoaiNhanVien.ColumnEdit = lookLoaiNhanVienn;
        }
        private void Form_QuanLyPhuXe_Load(object sender, EventArgs e)
        {
            LoadDanhSachNhanVien();
        }

        private void grvNhanVien_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaPX.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "ID");
            txtTenPX.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "HOTENPX");
            txtDiaChi.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "DIACHI");
            dateNgaySinh.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "NGAYSINH");
            txtSDT.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "SDT");
            cbbGioiTinh.EditValue = grvNhanVien.GetRowCellValue(e.FocusedRowHandle, "GIOITINH");
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // nhanvien = new NHANVIEN();
                if (string.IsNullOrEmpty(txtTenPX.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống", "Thông báo");
                    this.txtTenPX.Focus();
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
                phuxe.HOTENPX = txtTenPX.Text;
                phuxe.GIOITINH = cbbGioiTinh.Text;
                phuxe.NGAYSINH = DateTime.Parse(dateNgaySinh.Text.ToString());
                phuxe.SDT = txtSDT.Text;
                phuxe.DIACHI = txtDiaChi.Text;
                phuxe.ID_LOAINV = 2;
                if (dal_QuanLyPhuXe.Themphuxe(phuxe) == true)
                {
                    XtraMessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công!", "Thông báo");
                }
                LoadDanhSachNhanVien();
            }
            catch
            {
                XtraMessageBox.Show("Lỗi!", "Thông báo");
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Bạn chắc chứ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    phuxe.ID = int.Parse(txtMaPX.Text);
                    dal_QuanLyPhuXe.Xoaphuxe(phuxe);
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
                phuxe.ID = int.Parse(txtMaPX.Text);
                phuxe.HOTENPX = txtTenPX.Text;
                phuxe.GIOITINH = cbbGioiTinh.Text;
                phuxe.NGAYSINH = DateTime.Parse(dateNgaySinh.Text.ToString());
                phuxe.SDT = txtSDT.Text;
                phuxe.DIACHI = txtDiaChi.Text;
                phuxe.ID_LOAINV = 2;
                dal_QuanLyPhuXe.Suaphuxe(phuxe);
                XtraMessageBox.Show("Sửa thành công!", "Thông báo");
                LoadDanhSachNhanVien();
            }
            catch
            {
                XtraMessageBox.Show("Lỗi!", "Thông báo");
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenPX.Text = "";
            dateNgaySinh.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtMaPX.Text = "";
        }
    }
}