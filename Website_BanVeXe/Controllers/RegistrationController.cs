using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO_BanVeXe;
using BUS_BanVeXe;

namespace Website_BanVeXe.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection form)
        {
            try
            {
                if (form["hoten"] != null)
                {
                    string hoten = form["hoten"];
                    string email = form["email"];
                    string pass = form["pass"];
                    string sdt = form["sdt"];
                    string cmnd = form["cmnd"];
                    string diachi = form["diachi"];

                    DTO_DangKy dto_dangky = new DTO_DangKy();
                    dto_dangky.HoTen = hoten;
                    dto_dangky.Email = email;
                    dto_dangky.Pass = pass;
                    dto_dangky.SDT = sdt;
                    dto_dangky.CMND = cmnd;
                    dto_dangky.DiaChi = diachi;

                    BUS_DangKy bus_dangky = new BUS_DangKy();

                    if (bus_dangky.DangKy(dto_dangky) == true)
                    {
                        form["hoten"] = null;
                        return RedirectToAction("Index", "Login");
                    }
                    else return View();
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}

