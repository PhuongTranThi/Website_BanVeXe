using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_BanVeXe;
using BUS_BanVeXe;

namespace Website_BanVeXe.Areas.Admin.Controllers
{
    public class DiemDonController : Controller
    {
        // GET: Admin/DiemDon
        public ActionResult Index()
        {
            BUS_DiaDiemDon bus_diadiemdon = new BUS_DiaDiemDon();
            ViewData["diadiemdon"] = bus_diadiemdon.LoadDiaDiemDon();
            return View();
        }
    }
}