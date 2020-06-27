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
            var giokhoihanh = form["giokhoihanh"];


            ViewData["noidi"] = ndi;
            ViewData["noiden"] = nden;
            ViewData["dateStart"] = ngaykhoihanh;

            //ViewData["chuyendi"] = bus_Ghe.LoadChuyenDi(int.Parse(ndi.ToString()), int.Parse(nden.ToString()), ngaykhoihanh);
            var tuyendi = bus_Ghe.LoadTuyenDi(int.Parse(ndi.ToString()), int.Parse(nden.ToString()));
            ViewData["tuyendi"] = tuyendi;

            ViewData["diadiem"] = bus_Ghe.LoadDiaDiemDon(tuyendi[0].ID_Tuyen);
            if (ngaykhoihanh != null) {
                var chuyendi = bus_Ghe.LoadChuyenDi(tuyendi[0].ID_Tuyen, ngaykhoihanh);
                ViewData["xe"] = bus_Ghe.Load_Ghe_Xe(chuyendi[0].BienSo);
                ViewData["giokhoihanh"] = chuyendi;

                //ViewData["chuyendi"] = bus_chuyen.LoadChuyenDi();
                if (giokhoihanh != null) {
                    ViewData["xe"] = bus_Ghe.Load_Ghe_Xe(giokhoihanh);
                }
                else {
                    ViewData["xe"] = bus_Ghe.Load_Ghe_Xe(chuyendi[0].BienSo);
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult ViewChair(FormCollection form)
        {
            BUS_GHE bus_Ghe = new BUS_GHE();
            BUS_ChuyenDi bus_chuyen = new BUS_ChuyenDi();



            var ndi = form["noidi"];
            var nden = form["noiden"];
            var ngaykhoihanh = form["dateStart"];
            var giokhoihanh = form["giokhoihanh"];


            ViewData["noidi"] = ndi;
            ViewData["noiden"] = nden;
            ViewData["dateStart"] = ngaykhoihanh;

            //ViewData["chuyendi"] = bus_Ghe.LoadChuyenDi(int.Parse(ndi.ToString()), int.Parse(nden.ToString()), ngaykhoihanh);
            var tuyendi = bus_Ghe.LoadTuyenDi(int.Parse(ndi.ToString()), int.Parse(nden.ToString()));
            ViewData["tuyendi"] = tuyendi;

            ViewData["diadiem"] = bus_Ghe.LoadDiaDiemDon(tuyendi[0].ID_Tuyen);
            if (ngaykhoihanh != null)
            {
                var chuyendi = bus_Ghe.LoadChuyenDi(tuyendi[0].ID_Tuyen, ngaykhoihanh);
                ViewData["xe"] = bus_Ghe.Load_Ghe_Xe(chuyendi[0].BienSo);
                ViewData["giokhoihanh"] = chuyendi;

                //ViewData["chuyendi"] = bus_chuyen.LoadChuyenDi();
                if (giokhoihanh != null)
                {
                    ViewData["xe"] = bus_Ghe.Load_Ghe_Xe(giokhoihanh);
                }
                else
                {
                    ViewData["xe"] = bus_Ghe.Load_Ghe_Xe(chuyendi[0].BienSo);
                }
            }
            return View();
        }


    }
}