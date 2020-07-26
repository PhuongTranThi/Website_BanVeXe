using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DAL_BanVeXe;

namespace GUI_BanVeXe
{
    public partial class Form_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DAL_Winform_QuanLyNguoiDung CauHinh = new DAL_Winform_QuanLyNguoiDung();
        DAL_Winform_PhanQuyen dal_PhanQuyen = new DAL_Winform_PhanQuyen();

        string username;

        public string Username { get => username; set => username = value; }

        //public string Username { get => username; set => username = value; }

        public Form_Main(List<QL_PHANQUYEN> list)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin;
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            LoadDanhSachQuyen(list);
        }
       

       
        void LoadDanhSachQuyen(List<QL_PHANQUYEN> list)
        {
            foreach (QL_PHANQUYEN item in list)
            {

                if (item.MAMANHINH == ribbonHeThong.Tag.ToString())
                {
                    groupHeThong.Visible = true;

                }
                if (item.MAMANHINH == ribbonNghiepVu.Tag.ToString())
                {
                    ribbonNghiepVu.Visible = true;

                }
                if (item.MAMANHINH == ribbonDanhMuc.Tag.ToString())
                {
                    ribbonDanhMuc.Visible = true;

                }
                if (item.MAMANHINH == ribbonThongKe.Tag.ToString())
                {
                    ribbonThongKe.Visible = true;

                }
            }
        }
        public void ShowForm(Form f)
        {
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            f.Show();
        }
        //kiểm tra 1 form với tên nào đó đã hiển thị trong form cha chưa?
        private bool CheckExistForm(string name)
        {
            bool check = false; //chua
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    check = true;  //roi
                    break;
                }
            }
            return check;
        }
        //hiển thị lên trên cùng mà không phải tạo mới
        private void ActiveChildForm(string name)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    f.Activate();
                    break;
                }
            }
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("Form_DoiMatKhau"))
            {
                Form_DoiMatKhau dmk = new Form_DoiMatKhau();
                dmk.ShowDialog();
            }
            else
                ActiveChildForm("Form_DoiMatKhau");
        }

        private void btnQLNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnPhanQuyen_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("Form_PhanQuyen"))
            {
                Form_PhanQuyen pq = new Form_PhanQuyen();
                ShowForm(pq);
            }
            else
                ActiveChildForm("Form_PhanQuyen");
        }

        private void btnBanVe_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnQLTaiXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("Form_QuanLyTaiXe"))
            {
                Form_QuanLyTaiXe tx = new Form_QuanLyTaiXe();
                ShowForm(tx);
            }
            else
                ActiveChildForm("Form_QuanLyTaiXe");
        }

        private void btnQLPhuXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("Form_QuanLyPhuXe"))
            {
                Form_QuanLyPhuXe px = new Form_QuanLyPhuXe();
                ShowForm(px);
            }
            else
                ActiveChildForm("Form_QuanLyPhuXe");
        }

        private void btnNVBanVe_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnQLKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnQLXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("Form_QuanLyXe"))
            {
                Form_QuanLyXe xe = new Form_QuanLyXe();
                ShowForm(xe);
            }
            else
                ActiveChildForm("Form_QuanLyXe");
        }

        private void btnQLTuyenDi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("Form_QuanLyTuyenDi"))
            {
                Form_QuanLyTuyenDi td = new Form_QuanLyTuyenDi();
                ShowForm(td);
            }
            else
                ActiveChildForm("Form_QuanLyTuyenDi");
        }

        private void btnQLChuyenDi_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnQLDDDonKhach_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("Form_DangNhap"))
            {
                if (XtraMessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Form_DangNhap dx = new Form_DangNhap();
                    this.Hide();
                    dx.ShowDialog();
                    this.Show();

                }

            }
            else
                ActiveChildForm("Form_DangNhap");
        }
    }
}