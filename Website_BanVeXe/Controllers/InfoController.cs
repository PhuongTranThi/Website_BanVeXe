using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website_BanVeXe.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {

                var noidi = form["noidi"];
                var noiden = form["noiden"];
                var idChuyen = form["idChuyenDi"];
                var dateStart = form["dateStart"];
                var diadiemSelect = form["diadiemSelect"];
                var gheSelect = form["gheSelect"];
                var donGiaNha = form["donGiaNha"];

                ViewData["idChuyenDi"] = idChuyen;
                ViewData["dateStart"] = dateStart;
                ViewData["noidi"] = noidi;
                ViewData["noiden"] = noiden;
                ViewData["diadiemSelect"] = diadiemSelect;
                ViewData["gheSelect"] = gheSelect;
                ViewData["donGiaNha"] = donGiaNha;
                return View();
        }
    }
}