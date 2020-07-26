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
        public ActionResult CreateChuyenDi()
        {
            BUS_ChuyenDi bus_chuyendi = new BUS_ChuyenDi();
            ViewData["xe"] = bus_chuyendi.LoadXe();
            ViewData["tuyendi"] = bus_chuyendi.LoadTuyenDi();
            ViewData["taixe"] = bus_chuyendi.LoadTaiXe();
            ViewData["phuxe"] = bus_chuyendi.LoadPhuXe();
            return View();
        }
        [HttpPost]
        public ActionResult CreateChuyenDi(FormCollection collection)
        {
            BUS_ChuyenDi bus_chuyendi = new BUS_ChuyenDi();

            var tuyendi = collection["tuyendi"];
            var xe = collection["xe"];
            var taixe = collection["taixe"];
            var phuxe = collection["phuxe"];
            var ngaykhoihanh = collection["ngaykhoihanh"];
            var giodi = collection["giodi"];

            CHUYENDI insert = new CHUYENDI();
            insert.ID_TUYENDI = int.Parse(tuyendi.ToString());
            insert.ID_XE = int.Parse(xe.ToString());
            insert.ID_TAIXE = int.Parse(taixe.ToString());
            insert.ID_PHUXE = int.Parse(phuxe.ToString());
            insert.NGAYKHOIHANH = DateTime.Parse(ngaykhoihanh.ToString());
            insert.GIODI = TimeSpan.Parse(giodi.ToString());

            if (bus_chuyendi.InsertChuyenDi(insert))
            {
                return RedirectToAction("Index", "ChuyenDi");
            }
            else
            {
                return View();
            }
        }
        // POST: Admin/Login/Edit/:id
        public ActionResult EditChuyenDi(int id)
        {
            BUS_ChuyenDi bus_chuyendi = new BUS_ChuyenDi();
            CHUYENDI a = bus_chuyendi.LoadChuyenDiByID(id);
            ViewData["data"] = a;
            ViewData["id"] = id;
            return View();
        }
        // POST: Admin/Login/Edit/:id
        [HttpPost]
        public ActionResult EditChuyenDi(int id, FormCollection collection)
        {
            BUS_ChuyenDi bus_chuyendi = new BUS_ChuyenDi();
            try
            {
                var tuyendi = collection["tuyendi"];
                var xe = collection["xe"];
                var taixe = collection["taixe"];
                var phuxe = collection["phuxe"];
                var ngaykhoihanh = collection["ngaykhoihanh"];
                var giodi = collection["giodi"];

                CHUYENDI edit = new CHUYENDI();
                edit.ID_TUYENDI = int.Parse(tuyendi.ToString());
                edit.ID_XE = int.Parse(xe.ToString());
                edit.ID_TAIXE = int.Parse(taixe.ToString());
                edit.ID_PHUXE = int.Parse(phuxe.ToString());
                edit.NGAYKHOIHANH = DateTime.Parse(ngaykhoihanh.ToString());
                edit.GIODI = TimeSpan.Parse(giodi.ToString());

                if (bus_chuyendi.UpdateChuyenDiByID(id, edit))
                {
                    return RedirectToAction("Index", "ChuyenDi");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteChuyenDi(int id)
        {
            BUS_ChuyenDi bus_chuyendi = new BUS_ChuyenDi();
            if (bus_chuyendi.DeleteChuyenDiByID(id))
            {
                return RedirectToAction("Index", "ChuyenDi");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}