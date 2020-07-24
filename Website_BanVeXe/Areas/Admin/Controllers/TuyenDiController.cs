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
        public ActionResult CreateTuyenDi()
        {
            BUS_TuyenDi bus_tuyendi = new BUS_TuyenDi();
            ViewData["noidi"] = bus_tuyendi.LoadNoiDi();
            ViewData["noiden"] = bus_tuyendi.LoadNoiDen();
            ViewData["loaixe"] = bus_tuyendi.LoadLoaiXe();
            return View();
        }
        [HttpPost]
        public ActionResult CreateTuyenDi(FormCollection collection)
        {
            BUS_TuyenDi bus_tuyendi = new BUS_TuyenDi();

            var noidi = collection["noidi"];
            var noiden = collection["noiden"];
            var loaixe = collection["loaixe"];
            var tentuyen = collection["tentuyen"];
            var dongia = collection["dongia"];
            var khoangcach = collection["khoangcach"];
            var sogiochay = collection["sogiochay"];

            TUYENDI insert = new TUYENDI();
            insert.ID_NOIDI = int.Parse(noidi.ToString());
            insert.ID_NOIDEN = int.Parse(noiden.ToString());
            insert.ID_LOAIXE = int.Parse(loaixe.ToString());
            insert.TENTUYEN = tentuyen;
            insert.DONGIA = float.Parse(dongia.ToString());
            insert.KHOANGCACH = float.Parse(khoangcach.ToString());
            insert.SOGIOCHAY = float.Parse(sogiochay.ToString());

            if (bus_tuyendi.InsertTuyeDi(insert))
            {
                return RedirectToAction("Index", "TuyenDi");
            }
            else
            {
                return View();
            }
        }
        // POST: Admin/Login/Edit/:id
        public ActionResult EditTuyenDi(int id)
        {
            BUS_TuyenDi bus_tuyendi = new BUS_TuyenDi();
            TUYENDI a = bus_tuyendi.LoadTuyenDiByID(id);
            ViewData["data"] = a;
            ViewData["id"] = id;
            return View();
        }
        // POST: Admin/Login/Edit/:id
        [HttpPost]
        public ActionResult EditTuyenDi(int id, FormCollection collection)
        {
            BUS_TuyenDi bus_tuyendi = new BUS_TuyenDi();
            try
            {
                var noidi = collection["noidi"];
                var noiden = collection["noiden"];
                var loaixe = collection["loaixe"];
                var tentuyen = collection["tentuyen"];
                var dongia = collection["dongia"];
                var khoangcach = collection["khoangcach"];
                var sogiochay = collection["sogiochay"];

                TUYENDI edit = new TUYENDI();
                edit.ID_NOIDI = int.Parse(noidi.ToString());
                edit.ID_NOIDEN = int.Parse(noiden.ToString());
                edit.ID_LOAIXE = int.Parse(loaixe.ToString());
                edit.TENTUYEN = tentuyen;
                edit.DONGIA = float.Parse(dongia.ToString());
                edit.KHOANGCACH = float.Parse(khoangcach.ToString());
                edit.SOGIOCHAY = float.Parse(sogiochay.ToString());

                if (bus_tuyendi.UpdateTuyenDiByID(id, edit))
                {
                    return RedirectToAction("Index", "TuyenDi");
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

        public ActionResult DeleteTuyenDi(int id)
        {
            BUS_TuyenDi bus_tuyendi = new BUS_TuyenDi();
            if (bus_tuyendi.DeleteTuyenDiByID(id))
            {
                return RedirectToAction("Index", "TuyenDi");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}