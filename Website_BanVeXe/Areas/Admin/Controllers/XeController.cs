using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_BanVeXe;
using BUS_BanVeXe;

namespace Website_BanVeXe.Areas.Admin.Controllers
{
    public class XeController : Controller
    {
        // GET: Admin/Xe
        public ActionResult Index()
        {
            BUS_Xe bus_xe = new BUS_Xe();
            ViewData["xe"] = bus_xe.LoadXe();
            return View();
        }
    }
}