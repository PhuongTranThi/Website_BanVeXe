using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BanVeXe
{
    public class DAL_Winform_QuanLyNguoiDung
    {
        public int Check_Config()
        {
            if (Properties.Settings.Default.QL_PhanQuyen == string.Empty)
                return 1; //chuoi cau hinh khong ton tai
            SqlConnection _Sqlconn = new SqlConnection(Properties.Settings.Default.QL_PhanQuyen);
            try
            {
                if (_Sqlconn.State == System.Data.ConnectionState.Closed)
                    _Sqlconn.Open();
                return 0; //ket noi thanh cong chuoi cau hinh hopj le

            }
            catch
            {
                return 2; //chuoi cau hinh khong phu hop
            }
        }
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from QL_NGUOIDUNG where TENDANGNHAP='" + pUser + "'and MATKHAU ='" + pPass + "'",
                Properties.Settings.Default.QL_PhanQuyen);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
                return 1; //user khong ton tai
            else if (dt.Rows[0][2] == null || dt.Rows[0][2].ToString() == "False")
            {
                return 2;
            }
            return 0;
        }
        public List<string> GetServerName()
        {
            List<string> ls = new List<string>();

            DataTable dt = new DataTable();
            dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string ten = dt.Rows[i].ItemArray[0].ToString();
                ls.Add(ten + @"\SQLEXPRESS");
            }
            return ls;
        }
        public DataTable GetDBName(string pServer, string pUser, string pPass)
        {
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases", "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";Password=" + pPass + "");
            da.Fill(dt);
            return dt;

        }
        public void SaveConfig(string pServer, string pUser, string pPass, string pDBName)
        {
            DAL_BanVeXe.Properties.Settings.Default.QL_PhanQuyen = "Data Source=" + pServer + ";Integrated Security=True;Initial Catalog=" + pDBName + "";
            DAL_BanVeXe.Properties.Settings.Default.Save();
        }

    }
}
