using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_BanVeXe;
using DTO_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_TuyenDi
    {
        DAL_TuyenDi dalTuyenDi = new DAL_TuyenDi();

        public List<TUYENDI> LoadTuyenDi()
        {
            return dalTuyenDi.LoadTuyenDi();
        }
        public List<NOIDI> LoadNoiDi()
        {
            return dalTuyenDi.LoadNoiDi();
        }
        public List<NOIDEN> LoadNoiDen()
        {
            return dalTuyenDi.LoadNoiDen();
        }
        public List<LOAIXE> LoadLoaiXe()
        {
            return dalTuyenDi.LoadLoaiXe();
        }
        public List<DTO_Admin_TuyenDi> LoadTuyenDiAdmin()
        {
            return dalTuyenDi.LoadTuyenDiAdmin();
        }
        //them xóa sửa admin
        public TUYENDI LoadTuyenDiByID(int id)
        {
            return dalTuyenDi.LoadTuyenDiByID(id);
        }
        public bool UpdateTuyenDiByID(int id, TUYENDI td)
        {
            return dalTuyenDi.UpdateTuyenDiByID(id, td);
        }
        public bool DeleteTuyenDiByID(int id)
        {
            return dalTuyenDi.DeleteTuyenDiByID(id);
        }
        public bool InsertTuyeDi(TUYENDI td)
        {
            return dalTuyenDi.InsertTuyenDi(td);
        }
    }
}
