using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BUS_BanVeXe;
using DAL_BanVeXe;
using DTO_BanVeXe;

namespace Website_BanVeXe.Controllers
{
    public class BookController : Controller
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        List<int> listSelected;
        // GET: Book
        public void addItemChair(int value)
        {
            listSelected.Add(value);
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            BUS_GHE bus_Ghe = new BUS_GHE();
            BUS_ChuyenDi bus_chuyen = new BUS_ChuyenDi();

           
          
            var ndi = form["noidi"];
            var nden = form["noiden"];
            var ngaykhoihanh = form["dateStart"];

            
            ViewData["noidi"] = ndi;
            ViewData["noiden"] = nden;
            ViewData["dateStart"] = ngaykhoihanh;

            //ViewData["chuyendi"] = bus_Ghe.LoadChuyenDi(int.Parse(ndi.ToString()), int.Parse(nden.ToString()), ngaykhoihanh);
            var chuyenxedi = bus_Ghe.LoadTuyenDi(int.Parse(ndi.ToString()), int.Parse(nden.ToString()));
            ViewData["tuyendi"] = chuyenxedi;

            ViewData["diadiem"] = bus_Ghe.LoadDiaDiemDon(chuyenxedi[0].ID_Tuyen);
            
            if (ngaykhoihanh != null)
            {
                ViewData["giokhoihanh"] = bus_Ghe.LoadChuyenDi(chuyenxedi[0].ID_Tuyen, ngaykhoihanh);
            }
            //ViewData["chuyendi"] = bus_chuyen.LoadChuyenDi();

            ViewData["xe"] = bus_Ghe.Load_Ghe_Xe("55A-31589");

            return View();
        }

      
    }
}