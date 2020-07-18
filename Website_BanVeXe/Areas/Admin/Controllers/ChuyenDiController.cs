using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BUS_BanVeXe;
using DAL_BanVeXe;

namespace Website_BanVeXe.Areas.Admin.Controllers
{
    public class ChuyenDiController : Controller
    {
        // GET: Admin/ChuyenDi
        public ActionResult Index()
        {
            BUS_ChuyenDi bus_chuyendi = new BUS_ChuyenDi();
            ViewData["chuyendi"] = bus_chuyendi.LoadChuyenAdmin();
            return View();
        }
    }
}