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

        public ActionResult CreateDD()
        {
            BUS_DiaDiemDon bus_diadiemdon = new BUS_DiaDiemDon();
            ViewData["tuyendi"] = bus_diadiemdon.LoadTuyenDi();
            return View();
        }
        [HttpPost]
        public ActionResult CreateDD(FormCollection collection)
        {
            BUS_DiaDiemDon bus_diadiemdon = new BUS_DiaDiemDon();

            var tendd = collection["tendd"];
            var tuyendi = collection["tuyendi"];

            DIADIEMLENXE insert = new DIADIEMLENXE();
            insert.TENDD = tendd;
            insert.ID_TUYENDI = int.Parse(tuyendi.ToString());


            if (bus_diadiemdon.InsertDD(insert))
            {
                return RedirectToAction("Index", "DiemDon");
            }
            else
            {
                return View();
            }
        }
        // POST: Admin/Login/Edit/:id
        public ActionResult EditDD(int id)
        {
            BUS_DiaDiemDon bus_diadiemdon = new BUS_DiaDiemDon();
            DIADIEMLENXE a = bus_diadiemdon.LoadDDByID(id);
            ViewData["data"] = a;
            ViewData["id"] = id;
            return View();
        }
        // POST: Admin/Login/Edit/:id
        [HttpPost]
        public ActionResult EditDD(int id, FormCollection collection)
        {
            BUS_DiaDiemDon bus_diadiemdon = new BUS_DiaDiemDon();
            try
            {
                var tendd = collection["tendd"];
                var tuyendi = collection["tuyendi"];

                DIADIEMLENXE edit = new DIADIEMLENXE();
                edit.TENDD = tendd;
                edit.ID_TUYENDI = int.Parse(tuyendi.ToString());


                if (bus_diadiemdon.UpdateDDByID(id, edit))
                {
                    return RedirectToAction("Index", "DiemDon");
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

        public ActionResult DeleteDD(int id)
        {
            BUS_DiaDiemDon bus_diadiemdon = new BUS_DiaDiemDon();
            if (bus_diadiemdon.DeleteDDByID(id))
            {
                return RedirectToAction("Index", "DiemDon");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}