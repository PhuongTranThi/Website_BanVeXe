using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website_BanVeXe.Areas.Admin.Controllers
{
    public class LogoutAdminController : Controller
    {
        // GET: Admin/LogoutAdmin
        public ActionResult Index()
        {
            Session["user"] = null;
            return RedirectToAction("Index", "LoginAdmin");
        }
    }
}