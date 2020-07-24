using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;

namespace BUS_BanVeXe
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_nhanvien = new DAL_NhanVien();
        public List<LOAINHANVIEN> LoadLoaiNV()
        {
            return dal_nhanvien.LoadLoaiNhanVien();
        }
        public List<DTO_TaiXe> LoadTaiXe()
        {
            return dal_nhanvien.LoadTaiXe();
        }
        public List<DTO_PhuXe> LoadPhuXe()
        {
            return dal_nhanvien.LoadPhuXe();
        }
        public List<DTO_NhanVienBanVe> LoadNVBanVe()
        {
            return dal_nhanvien.LoadNhanVienBanVe();
        }


        public TAIXE LoadTaiXeByID(int id)
        {
            return dal_nhanvien.LoadTaiXeByID(id);
        }
        public PHUXE LoadPhuXeByID(int id)
        {
            return dal_nhanvien.LoadPhuXeByID(id);
        }
        public NHANVIEN LoadNVBanVeByID(int id)
        {
            return dal_nhanvien.LoadNVBanVeByID(id);
        }


        public bool UpdateTaiXeByID(int id, TAIXE tx)
        {
            return dal_nhanvien.UpdateTaiXeByID(id, tx);
        }
        public bool DeleteTaiXeByID(int id)
        {
            return dal_nhanvien.DeleteTaiXeByID(id);
        }
        public bool InsertTaiXe(TAIXE tx)
        {
            return dal_nhanvien.InsertTaiXe(tx);
        }


        public bool UpdatePhuXeByID(int id, PHUXE px)
        {
            return dal_nhanvien.UpdatePhuXeByID(id, px);
        }
        public bool DeletePhuXeByID(int id)
        {
            return dal_nhanvien.DeletePhuXeByID(id);
        }
        public bool InsertPhuXe(PHUXE px)
        {
            return dal_nhanvien.InsertPhuXe(px);
        }


        public bool UpdateNVBanVeByID(int id, NHANVIEN nvbv)
        {
            return dal_nhanvien.UpdateNVBanVeByID(id, nvbv);
        }
        public bool DeleteNVBanVeByID(int id)
        {
            return dal_nhanvien.DeleteNVBanVeByID(id);
        }
        public bool InsertNVBanVe(NHANVIEN nvbv)
        {
            return dal_nhanvien.InsertNVBanVe(nvbv);
        }
    }
}
