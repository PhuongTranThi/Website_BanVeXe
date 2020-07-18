using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_BanVeXe;
using BUS_BanVeXe;

namespace Website_BanVeXe.Areas.Admin.Controllers
{
    public class DSKhachHangController : Controller
    {
        // GET: Admin/DSKhachHang
        public ActionResult Index()
        {
            BUS_KhachHang bus_khachhang = new BUS_KhachHang();
            ViewData["khachhang"] = bus_khachhang.LoadKhachHang();
            return View();
        }

    }
}