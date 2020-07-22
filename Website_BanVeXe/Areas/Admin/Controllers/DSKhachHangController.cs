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
        BUS_KhachHang bus_khachhang = new BUS_KhachHang();
        // GET: Admin/DSKhachHang
        public ActionResult Index()
        {
            ViewData["khachhang"] = bus_khachhang.LoadKhachHang();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Login/Edit/:id

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            var cmnd = collection["cmnd"];
            var email = collection["email"];
            var hoten = collection["hoten"];
            var diachi = collection["diachi"];
            var sdt = collection["sdt"];

            KHACHHANG insert = new KHACHHANG();
            insert.CMND = cmnd;
            insert.DIACHI = diachi;
            insert.EMAIL = email;
            insert.HOTENKH = hoten;
            insert.SDT = sdt;
            insert.PASSWORD = "1231";

            if (bus_khachhang.InsertKhachHang(insert))
            {
                return RedirectToAction("Index", "DSKhachHang");
            }
            else
            {
                return View();
            }
        }

        // POST: Admin/Login/Edit/:id
        public ActionResult Edit(int id)
        {
            KHACHHANG a = bus_khachhang.LoadKhachHangByID(id);
            ViewData["data"] = a;
            ViewData["id"] = id;
            return View();
        }

        // POST: Admin/Login/Edit/:id
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                var cmnd = collection["cmnd"];
                var email = collection["email"];
                var hoten = collection["hoten"];
                var diachi = collection["diachi"];
                var sdt = collection["sdt"];

                KHACHHANG edit = new KHACHHANG();
                edit.CMND = cmnd;
                edit.EMAIL = email;
                edit.HOTENKH = hoten;
                edit.DIACHI = diachi;
                edit.SDT = sdt;

                if (bus_khachhang.UpdateKhachHangByID(id, edit))
                {
                    return RedirectToAction("Index","DSKhachHang");
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

        public ActionResult Delete(int id)
        {
            if (bus_khachhang.DeleteKhachHangByID(id))
            {
                return RedirectToAction("Index", "DSKhachHang");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}