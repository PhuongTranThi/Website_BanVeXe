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
    public partial class Form_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }
        Data_BanVeXeDataContext db = new Data_BanVeXeDataContext();
        DAL_Winform_QuanLyNguoiDung CauHinh = new DAL_Winform_QuanLyNguoiDung();
        List<QL_PHANQUYEN> Quyen;
        string nhanvien;

        public string Nhanvien { get => nhanvien; set => nhanvien = value; }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + "" + lblUserName.Text.ToLower());
                this.txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + "" + lblPass.Text.ToLower());
                this.txtPass.Focus();
                return;
            }
            int kq = CauHinh.Check_Config();
            if (kq == 0)
            {
                ProcessLogin(); //cau hinh phu hop xu ly dang nhap
                nhanvien = txtUser.Text;
            }
            if (kq == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại!", "Thông báo");
                ProcessConfig();

            }
            if (kq == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp!", "Thông báo");
                ProcessConfig();

            }
        }
        public void ProcessLogin()
        {
            if (CheckLogin(txtUser.Text, txtPass.Text))
            {
                Quyen = new List<QL_PHANQUYEN>();
                Quyen = LayQuyen(txtUser.Text);
                Form_Main f = new Form_Main(Quyen);
                this.Hide();
                f.Username = Nhanvien;
                f.ShowDialog();
                this.Show();
            }
            else
                XtraMessageBox.Show("Bạn nhập sai rồi!", "Thông báo");

        }
        public void ProcessConfig()
        {
            if (Program.formCauHinh == null || Program.formCauHinh.IsDisposed)
            {
                Program.formCauHinh = new Form_CauHinh();
            }
            this.Visible = false;
            Program.formCauHinh.Show();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }
        bool CheckLogin(string user, string pass)
        {
            List<QL_NGUOIDUNG> list = new List<QL_NGUOIDUNG>();
            list = db.QL_NGUOIDUNGs.Where(p => p.TENDANGNHAP == user && p.MATKHAU == pass).ToList<QL_NGUOIDUNG>();
            if (list.Count > 0)
                return true;
            return false;
        }
        List<QL_PHANQUYEN> LayQuyen(string TenDangNhap)
        {
            return (from Ql_PQ in db.QL_PHANQUYENs
                    from QL_NDNND in db.QL_NGUOIDUNGNHOMNGUOIDUNGs
                    where Ql_PQ.MANHOMNGUOIDUNG == QL_NDNND.MANHOMNGUOIDUNG && QL_NDNND.TENDANGNHAP == TenDangNhap
                    select Ql_PQ).ToList<QL_PHANQUYEN>();

        }
    }
}