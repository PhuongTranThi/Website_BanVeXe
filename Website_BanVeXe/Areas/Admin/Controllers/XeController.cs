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
        BUS_Xe bus_xe = new BUS_Xe();
        // GET: Admin/Xe
        public ActionResult Index()
        {
            BUS_Xe bus_xe = new BUS_Xe();
            ViewData["xe"] = bus_xe.LoadXe();
            return View();
        }

        public ActionResult CreateXe()
        {
            BUS_Xe bus_xe = new BUS_Xe();
            ViewData["loaixe"] = bus_xe.LoadLoaiXe();
            return View();
        }
        [HttpPost]
        public ActionResult CreateXe(FormCollection collection)
        {
            BUS_Xe bus_xe = new BUS_Xe();

            var bienso = collection["bienso"];
            var trangthai = collection["trangthai"];
            var loaixe = collection["loaixe"];

            XE insert = new XE();
            insert.BIENSO = bienso;
            insert.TRANGTHAI = trangthai;
            insert.ID_LOAIXE = int.Parse(loaixe.ToString());
          

            if (bus_xe.InsertXe(insert))
            {
                return RedirectToAction("Index", "Xe");
            }
            else
            {
                return View();
            }
        }
        // POST: Admin/Login/Edit/:id
        public ActionResult EditXe(int id)
        {
            BUS_Xe bus_xe = new BUS_Xe();
            XE a = bus_xe.LoadXeByID(id);
            ViewData["data"] = a;
            ViewData["id"] = id;
            return View();
        }
        // POST: Admin/Login/Edit/:id
        [HttpPost]
        public ActionResult EditXe(int id, FormCollection collection)
        {
            BUS_Xe bus_xe = new BUS_Xe();
            try
            {
                var bienso = collection["bienso"];
                var trangthai = collection["trangthai"];
                var loaixe = collection["loaixe"];

                XE edit = new XE();
                edit.BIENSO = bienso;
                edit.TRANGTHAI = trangthai;
                edit.ID_LOAIXE = int.Parse(loaixe.ToString());
                

                if (bus_xe.UpdateXeByID(id, edit))
                {
                    return RedirectToAction("Index", "Xe");
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

        public ActionResult DeleteXe(int id)
        {
            BUS_Xe bus_xe = new BUS_Xe();
            if (bus_xe.DeleteXeByID(id))
            {
                return RedirectToAction("Index", "Xe");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        //loại xe
        public ActionResult CreateLoaiXe()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateLoaiXe(FormCollection collection)
        {
            BUS_Xe bus_xe = new BUS_Xe();

            var tenloaixe = collection["tenloaixe"];
            var sochongoi = collection["sochongoi"];

            LOAIXE insert = new LOAIXE();
            insert.TENLOAIXE = tenloaixe;
            insert.SOCHONGOI = int.Parse(sochongoi.ToString());


            if (bus_xe.InsertLoaiXe(insert))
            {
                return RedirectToAction("Index", "Xe");
            }
            else
            {
                return View();
            }
        }
    }
}