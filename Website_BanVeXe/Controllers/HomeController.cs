using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_BanVeXe;
using BUS_BanVeXe;
using Website_BanVeXe.Models;

namespace Website_BanVeXe.Controllers
{

    public class HomeController : Controller
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        // GET: Home
        public ActionResult Index(FormCollection form)
        {
            BUS_TuyenDi busTuyenDi = new BUS_TuyenDi();
            //Load lên dropdown
            ViewData["noidi"] = busTuyenDi.LoadNoiDi();
            ViewData["noiden"] = busTuyenDi.LoadNoiDen();

            //truyền form từ view sang controller
            string noidi = form["noidi"];
            string noiden = form["noiden"];
            string date = form["dayStart"];

            return View();
        }
        [HttpGet]
        public ActionResult loadNoiDen (string noidi)
        {
            var noiden = from nden in _db.NOIDENs
                         from tuyen in _db.TUYENDIs
                         where nden.ID == tuyen.ID_NOIDEN
                         && tuyen.ID_NOIDI == int.Parse(noidi)
                         select new
                         {
                             id_noiden = nden.ID,
                             ten_noiden = nden.TENNOIDEN
                         };
            return Json(noiden, JsonRequestBehavior.AllowGet);
        }
    }
 }