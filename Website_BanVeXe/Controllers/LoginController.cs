using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL_BanVeXe;
using BUS_BanVeXe;
using DTO_BanVeXe;

namespace Website_BanVeXe.Controllers
{
    public class LoginController : Controller
    {
        Data_BanVeXeDataContext _db = new Data_BanVeXeDataContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(FormCollection form)
        {
            BUS_DangNhap bus_dangnhap = new BUS_DangNhap();
            try
            {
                string email = form["email"];
                string pass = form["pass"];
                if (bus_dangnhap.DangNhap(email, pass))
                {
                    DTO_DangKy dto_dangky = new DTO_DangKy();
                    KHACHHANG kh = bus_dangnhap.getKhachHang(email, pass);
                    Session["nameKH"] = kh.HOTENKH.ToString();
                    Session["idKH"] = kh.ID.ToString();
                    Session["email"] = kh.EMAIL.ToString();
                    Session["diachi"] = kh.DIACHI.ToString();
                    Session["sdt"] = kh.SDT.ToString();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            catch
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
    }
}