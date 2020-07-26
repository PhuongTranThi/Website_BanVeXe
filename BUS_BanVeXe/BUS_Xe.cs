using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_BanVeXe;
using DAL_BanVeXe;


namespace BUS_BanVeXe
{
    public class BUS_Xe
    {
        DAL_Xe dal_xe = new DAL_Xe();
        public List<DTO_Xe> LoadXe()
        {
            return dal_xe.LoadXe();
        }
        public List<LOAIXE> LoadLoaiXe()
        {
            return dal_xe.LoadLoaiXe();
        }
        public XE LoadXeByID(int id)
        {
            return dal_xe.LoadXeByID(id);
        }
        public bool UpdateXeByID(int id, XE xe)
        {
            return dal_xe.UpdateXeByID(id, xe);
        }
        public bool DeleteXeByID(int id)
        {
            return dal_xe.DeleteXeByID(id);
        }
        public bool InsertXe(XE xe)
        {
            return dal_xe.InsertXe(xe);
        }
        //loại xe
        public LOAIXE LoadLoaiXeByID(int id)
        {
            return dal_xe.LoadLoaiXeByID(id);
        }
        public bool InsertLoaiXe(LOAIXE loaixe)
        {
            return dal_xe.InsertLoaiXe(loaixe);
        }
    }
}
