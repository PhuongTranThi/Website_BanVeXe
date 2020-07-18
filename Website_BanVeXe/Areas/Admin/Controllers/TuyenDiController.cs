using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_BanVeXe;
using BUS_BanVeXe;


namespace Website_BanVeXe.Areas.Admin.Controllers
{
    public class TuyenDiController : Controller
    {
        // GET: Admin/TuyenDi
        public ActionResult Index()
        {
            BUS_TuyenDi bus_tuyendi = new BUS_TuyenDi();
            ViewData["tuyendi"] = bus_tuyendi.LoadTuyenDiAdmin();
            return View();
        }
    }
}