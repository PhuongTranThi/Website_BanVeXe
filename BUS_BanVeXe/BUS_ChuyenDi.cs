using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_ChuyenDi
    {
        DAL_ChuyenDi dal_chuyendi = new DAL_ChuyenDi();

        public List<CHUYENDI> LoadChuyenDi()
        {
            return dal_chuyendi.LoadChuyen();
        }
        public List<DTO_ChuyenDi> Load_Tuyen_BienSo(int id_chuyen)
        {
            return dal_chuyendi.LoadTuyen_BienSo(id_chuyen);
        }
        public List<DIADIEMLENXE> LoadDiaDiemLenXe(int id_diadiem)
        {
            // [{tenddd: "ten"}]
            return dal_chuyendi.LoadDiaDiemLenXe(id_diadiem);
        }
        public List<DTO_Admin_ChuyenDi> LoadChuyenAdmin()
        {
            return dal_chuyendi.LoadChuyenAdmin();
        }
        //load view
        public List<XE> LoadXe()
        {
            return dal_chuyendi.LoadXe();
        }
        public List<TUYENDI> LoadTuyenDi()
        {
            return dal_chuyendi.LoadTuyenDi();
        }
        public List<TAIXE> LoadTaiXe()
        {
            return dal_chuyendi.LoadTaiXe();
        }
        public List<PHUXE> LoadPhuXe()
        {
            return dal_chuyendi.LoadPhuXe();
        }
        //thêm xóa sưae
        public CHUYENDI LoadChuyenDiByID(int id)
        {
            return dal_chuyendi.LoadChuyenDiByID(id);
        }
        public bool UpdateChuyenDiByID(int id, CHUYENDI cd)
        {
            return dal_chuyendi.UpdateChuyenDiByID(id, cd);
        }
        public bool DeleteChuyenDiByID(int id)
        {
            return dal_chuyendi.DeleteChuyenDiByID(id);
        }
        public bool InsertChuyenDi(CHUYENDI cd)
        {
            return dal_chuyendi.InsertChuyenDi(cd);
        }
    }
}
