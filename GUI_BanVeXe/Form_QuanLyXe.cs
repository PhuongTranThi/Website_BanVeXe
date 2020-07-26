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
    public partial class Form_QuanLyXe : DevExpress.XtraEditors.XtraForm
    {
        public Form_QuanLyXe()
        {
            InitializeComponent();
        }
        DAL_Winform_Xe dal_QuanLyXe = new DAL_Winform_Xe();
        DAL_Winform_LoaiXe loaixe = new DAL_Winform_LoaiXe();
        XE xe = new XE();

        void LoadDanhSachXe()
        {
            grcXe.DataSource = dal_QuanLyXe.LoadXe();

            lookLoaiXe2.DataSource = loaixe.LoadLoaiXe();
            lookLoaiXe2.DisplayMember = "TENLOAIXE";
            lookLoaiXe2.ValueMember = "ID";

            ColumnLoaiXe.ColumnEdit = lookLoaiXe2;
        }


        private void Form_QuanLyXe_Load(object sender, EventArgs e)
        {
            lookLoaiXe.Properties.DataSource = loaixe.LoadLoaiXe();
            lookLoaiXe.Properties.DisplayMember = "TENLOAIXE";
            lookLoaiXe.Properties.ValueMember = "ID";
            lookLoaiXe.Properties.NullText = @"Chọn loại xe";
            LoadDanhSachXe();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtBienSo.Text = "";
            txtMaXe.Text = "";
        }

        private void grvXe_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            txtMaXe.EditValue = grvXe.GetRowCellValue(e.FocusedRowHandle, "ID");
            txtBienSo.EditValue = grvXe.GetRowCellValue(e.FocusedRowHandle, "BIENSO");
            lookLoaiXe.EditValue = grvXe.GetRowCellValue(e.FocusedRowHandle, "ID_LOAIXE");
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
               
                if (string.IsNullOrEmpty(txtBienSo.Text.Trim()))
                {
                    MessageBox.Show("Không được bỏ trống", "Thông báo");
                    this.txtBienSo.Focus();
                    return;
                }

                
                xe.BIENSO = txtBienSo.Text;
                xe.ID_LOAIXE = int.Parse(lookLoaiXe.EditValue.ToString());
                if (dal_QuanLyXe.Them(xe) == true)
                {
                    XtraMessageBox.Show("Thêm thành công!", "Thông báo");
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công!", "Thông báo");
                }
                LoadDanhSachXe();
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
                    xe.ID = int.Parse(txtMaXe.Text);
                    dal_QuanLyXe.Xoa(xe);
                    XtraMessageBox.Show("Xóa thành công!", "Thông báo");
                    LoadDanhSachXe();
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi!", "Thông báo");
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                xe.ID = int.Parse(txtMaXe.Text);
                xe.BIENSO = txtBienSo.Text;
                xe.ID_LOAIXE = int.Parse(lookLoaiXe.EditValue.ToString());
                //xe.IDLoaiXe = Convert.ToInt32(lookLoaiXe.EditValue.ToString());
                //grvXe.UpdateCurrentRow();
                dal_QuanLyXe.Sua(xe);
                XtraMessageBox.Show("Sửa thành công!", "Thông báo");
                LoadDanhSachXe();
            }
            catch { XtraMessageBox.Show("Lỗi!", "Thông báo"); }
        }
    }
}