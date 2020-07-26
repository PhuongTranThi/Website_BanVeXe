using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;

namespace DAL_BanVeXe
{
    public class DAL_Xe
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        public List<DTO_Xe> LoadXe()
        {
            var phuong = from xe in _db.XEs
                         from loaixe in _db.LOAIXEs
                         where xe.ID_LOAIXE == loaixe.ID
                         select new
                         {
                             id_xe = xe.ID,
                             bienso = xe.BIENSO,
                             trangthai = xe.TRANGTHAI,
                             id_loaixe = loaixe.ID,
                             tenloaixe = loaixe.TENLOAIXE,
                             sochongoi = loaixe.SOCHONGOI
                         };
            List<DTO_Xe> result = phuong.ToList().ConvertAll(t => new DTO_Xe
            {
                ID_Xe = t.id_xe,
                BienSo = t.bienso,
                TrangThai = t.trangthai,
                ID_LoaiXe = int.Parse(t.id_loaixe.ToString()),
                TenLoaiXe = t.tenloaixe,
                SoChoNgoi = int.Parse(t.sochongoi.ToString())
               

            });
            return result.ToList<DTO_Xe>();
        }
        //load loại xe
        public List<LOAIXE> LoadLoaiXe()
        {
            return _db.LOAIXEs.Select(p => p).ToList<LOAIXE>();
        }
        //thêm xóa sửa admin xe
        public XE LoadXeByID(int id)
        {
            return _db.XEs.Where(p => p.ID == id).SingleOrDefault();
        }

        public bool UpdateXeByID(int id, XE xe)
        {
            XE update = _db.XEs.Where(p => p.ID == id).SingleOrDefault();
            try
            {
                update.ID_LOAIXE = xe.ID_LOAIXE;
                update.BIENSO = xe.BIENSO;
                update.TRANGTHAI = xe.TRANGTHAI;
                _db.SubmitChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteXeByID(int id)
        {
            try
            {
                XE del = _db.XEs.Where(p => p.ID == id).SingleOrDefault();
                _db.XEs.DeleteOnSubmit(del);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertXe(XE xe)
        {
            try
            {
                _db.XEs.InsertOnSubmit(xe);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //thêm admin loại xe
        public LOAIXE LoadLoaiXeByID(int id)
        {
            return _db.LOAIXEs.Where(p => p.ID == id).SingleOrDefault();
        }
        public bool InsertLoaiXe(LOAIXE loaixe)
        {
            try
            {
                _db.LOAIXEs.InsertOnSubmit(loaixe);
                _db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
