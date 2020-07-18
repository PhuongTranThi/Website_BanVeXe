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
    }
}
