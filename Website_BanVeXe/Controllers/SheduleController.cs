using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_BanVeXe;
using BUS_BanVeXe;

namespace Website_BanVeXe.Controllers
{
    public class SheduleController : Controller
    {
        // GET: Shedule
        public ActionResult Index()
        {
            BUS_TuyenDi busTuyenDi = new BUS_TuyenDi();
            BUS_LichTrinh bus_lichtrinh = new BUS_LichTrinh();
            ViewData["tuyendi"] = busTuyenDi.LoadTuyenDi();
            ViewData["lichtrinh"] = bus_lichtrinh.LoadLichTrinh();
            return View();
        }
    }
}