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
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        // GET: Admin/TaiVaPhuXe
        public ActionResult Index()
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            
            ViewData["taixe"] = bus_nhanvien.LoadTaiXe();
            ViewData["phuxe"] = bus_nhanvien.LoadPhuXe();
            ViewData["nvbanve"] = bus_nhanvien.LoadNVBanVe();
            return View();
        }
        public ActionResult CreateTaiXe()
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            ViewData["loainhanvien"] = bus_nhanvien.LoadLoaiNV();
            return View();
        }
        public ActionResult CreatePhuXe()
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            ViewData["loainhanvien"] = bus_nhanvien.LoadLoaiNV();
            return View();
        }
        public ActionResult CreateNVBanVe()
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            ViewData["loainhanvien"] = bus_nhanvien.LoadLoaiNV();
            return View();
        }
        [HttpPost]
        public ActionResult CreateTaiXe(FormCollection collection)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();

            var ngaysinh = collection["ngaysinh"];
            var gioitinh = collection["gioitinhSelect"];
            var hoten = collection["hoten"];
            var diachi = collection["diachi"];
            var sdt = collection["sdt"];
            var loainv = collection["loainv"];

            TAIXE insert = new TAIXE();
            insert.NGAYSINH = DateTime.Parse(ngaysinh.ToString());
            insert.GIOITINH = gioitinh;
            insert.HOTENTX = hoten;
            insert.DIACHI = diachi;
            insert.SDT = sdt;
            insert.ID_LOAINV = 2;

            if (bus_nhanvien.InsertTaiXe(insert))
            {
                return RedirectToAction("Index", "TaiVaPhuXe");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CreatePhuXe(FormCollection collection)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();

            var ngaysinh = collection["ngaysinh"];
            var gioitinh = collection["gioitinhSelect"];
            var hoten = collection["hoten"];
            var diachi = collection["diachi"];
            var sdt = collection["sdt"];
            var loainv = collection["loainv"];

            PHUXE insert = new PHUXE();
            insert.NGAYSINH = DateTime.Parse(ngaysinh.ToString());
            insert.GIOITINH = gioitinh;
            insert.HOTENPX = hoten;
            insert.DIACHI = diachi;
            insert.SDT = sdt;
            insert.ID_LOAINV = 3;

            if (bus_nhanvien.InsertPhuXe(insert))
            {
                return RedirectToAction("Index", "TaiVaPhuXe");
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult CreateNVBanVe(FormCollection collection)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();

            var ngaysinh = collection["ngaysinh"];
            var gioitinh = collection["gioitinhSelect"];
            var hoten = collection["hoten"];
            var diachi = collection["diachi"];
            var sdt = collection["sdt"];
            var loainv = collection["loainv"];

            NHANVIEN insert = new NHANVIEN();
            insert.NGAYSINH = DateTime.Parse(ngaysinh.ToString());
            insert.GIOITINH = gioitinh;
            insert.HOTENNV = hoten;
            insert.DIACHI = diachi;
            insert.SDT = sdt;
            insert.ID_LOAINV = 1;

            if (bus_nhanvien.InsertNVBanVe(insert))
            {
                return RedirectToAction("Index", "TaiVaPhuXe");
            }
            else
            {
                return View();
            }
        }

        // POST: Admin/Login/Edit/:id
        public ActionResult EditTaiXe(int id)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            TAIXE a = bus_nhanvien.LoadTaiXeByID(id);
            ViewData["data"] = a;
            ViewData["id"] = id;
            return View();
        }
        // POST: Admin/Login/Edit/:id
        [HttpPost]
        public ActionResult EditTaiXe(int id, FormCollection collection)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            try
            {
                var ngaysinh = collection["ngaysinh"];
                var gioitinh = collection["gioitinhSelect"];
                var hoten = collection["hoten"];
                var diachi = collection["diachi"];
                var sdt = collection["sdt"];
                var loainv = collection["loainv"];

                TAIXE edit = new TAIXE();
                edit.NGAYSINH = DateTime.Parse(ngaysinh.ToString());
                edit.GIOITINH = gioitinh;
                edit.HOTENTX = hoten;
                edit.DIACHI = diachi;
                edit.SDT = sdt;
                edit.ID_LOAINV = 2;

                if (bus_nhanvien.UpdateTaiXeByID(id, edit))
                {
                    return RedirectToAction("Index", "TaiVaPhuXe");
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

        public ActionResult DeleteTaiXe(int id)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            if (bus_nhanvien.DeleteTaiXeByID(id))
            {
                return RedirectToAction("Index", "TaiVaPhuXe");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        //phuj xe
        // POST: Admin/Login/Edit/:id
        public ActionResult EditPhuXe(int id)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            PHUXE a = bus_nhanvien.LoadPhuXeByID(id);
            ViewData["data"] = a;
            ViewData["id"] = id;
            return View();
        }
        // POST: Admin/Login/Edit/:id
        [HttpPost]
        public ActionResult EditPhuXe(int id, FormCollection collection)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            try
            {
                var ngaysinh = collection["ngaysinh"];
                var gioitinh = collection["gioitinhSelect"];
                var hoten = collection["hoten"];
                var diachi = collection["diachi"];
                var sdt = collection["sdt"];
                var loainv = collection["loainv"];

                PHUXE edit = new PHUXE();
                edit.NGAYSINH = DateTime.Parse(ngaysinh.ToString());
                edit.GIOITINH = gioitinh;
                edit.HOTENPX = hoten;
                edit.DIACHI = diachi;
                edit.SDT = sdt;
                edit.ID_LOAINV = 3;

                if (bus_nhanvien.UpdatePhuXeByID(id, edit))
                {
                    return RedirectToAction("Index", "TaiVaPhuXe");
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

        public ActionResult DeletePhuXe(int id)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            if (bus_nhanvien.DeletePhuXeByID(id))
            {
                return RedirectToAction("Index", "TaiVaPhuXe");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        //nhan vien ban ve
        // POST: Admin/Login/Edit/:id
        public ActionResult EditNVBanVe(int id)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            NHANVIEN a = bus_nhanvien.LoadNVBanVeByID(id);
            ViewData["data"] = a;
            ViewData["id"] = id;
            return View();
        }
        // POST: Admin/Login/Edit/:id
        [HttpPost]
        public ActionResult EditNVBanVe(int id, FormCollection collection)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            try
            {
                var ngaysinh = collection["ngaysinh"];
                var gioitinh = collection["gioitinhSelect"];
                var hoten = collection["hoten"];
                var diachi = collection["diachi"];
                var sdt = collection["sdt"];
                var loainv = collection["loainv"];

                NHANVIEN edit = new NHANVIEN();
                edit.NGAYSINH = DateTime.Parse(ngaysinh.ToString());
                edit.GIOITINH = gioitinh;
                edit.HOTENNV = hoten;
                edit.DIACHI = diachi;
                edit.SDT = sdt;
                edit.ID_LOAINV = 1;

                if (bus_nhanvien.UpdateNVBanVeByID(id, edit))
                {
                    return RedirectToAction("Index", "TaiVaPhuXe");
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

        public ActionResult DeleteNVBanVe(int id)
        {
            BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
            if (bus_nhanvien.DeleteNVBanVeByID(id))
            {
                return RedirectToAction("Index", "TaiVaPhuXe");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}