using DevExpress.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_BanVeXe;
using BUS_BanVeXe;

namespace Website_BanVeXe.Areas.Admin.Controllers
{
    public class TaiVaPhuXeController : Controller
    {
        // GET: Admin/TaiVaPhuXe
        public ActionResult Index()
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            
            ViewData["taixe"] = bus_nhanvien.LoadTaiXe();
            ViewData["phuxe"] = bus_nhanvien.LoadPhuXe();
            ViewData["nvbanve"] = bus_nhanvien.LoadNVBanVe();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
       


    }
}