using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_BanVeXe;
using BUS_BanVeXe;
using DTO_BanVeXe;

namespace Website_BanVeXe.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: Admin/LoginAdmin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhapAdmin(FormCollection form)
        {
            BUS_DangNhap bus_dangnhap = new BUS_DangNhap();
            try
            {
                string user = form["user"];
                string pass = form["pass"];
                if (bus_dangnhap.getDangNhap(user, pass))
                {
                    USER kh = bus_dangnhap.DangNhapAdmin(user, pass);
                    Session["user"] = kh.USERNAME.ToString();
                    Session["pass"] = kh.PASSWORD.ToString();

                    return RedirectToAction("Index", "DSKhachHang");

                }
                else
                {
                    return RedirectToAction("Index", "LoginAdmin");
                }
            }
            catch
            {
                return RedirectToAction("Index", "LoginAdmin");
            }

        }
    }
}