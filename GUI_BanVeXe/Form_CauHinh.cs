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
    public partial class Form_CauHinh : DevExpress.XtraEditors.XtraForm
    {
        public Form_CauHinh()
        {
            InitializeComponent();
        }
        DAL_Winform_QuanLyNguoiDung CauHinh = new DAL_Winform_QuanLyNguoiDung();

        private void btnCancel_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbServerName_DropDown(object sender, EventArgs e)
        {
            cbbServerName.DataSource = CauHinh.GetServerName();
            cbbServerName.DisplayMember = "ServerName";
        }

        private void cbbDatabase_DropDown(object sender, EventArgs e)
        {
            cbbDatabase.DataSource = CauHinh.GetDBName(cbbServerName.Text, txtUsername.Text, txtPassword.Text);
            cbbDatabase.DisplayMember = "name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CauHinh.SaveConfig(cbbServerName.Text, txtUsername.Text, txtPassword.Text, cbbDatabase.Text);
            this.Close();
            Form_DangNhap dn = new Form_DangNhap();
            dn.ShowDialog();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}