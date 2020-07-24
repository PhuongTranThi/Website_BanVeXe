using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BUS_BanVeXe;
using DAL_BanVeXe;
using DTO_BanVeXe;

namespace Website_BanVeXe.Areas.Admin.Controllers
{
    public class DatVeChoKhachController : Controller
    {
        // GET: Admin/DatVeChoKhach
        public ActionResult Index(FormCollection form)
        {
            try
            {
                BUS_GHE bus_Ghe = new BUS_GHE();
                BUS_ChuyenDi bus_chuyen = new BUS_ChuyenDi();

                var noidi = form["noidi"];
                var noiden = form["noiden"];
                var ngaykhoihanh = form["dateStart"];
                var giokhoihanh = form["giokhoihanh"];
                var idChuyenDi = form["idChuyenDi"];

                ViewData["noidi"] = noidi;
                ViewData["noiden"] = noiden;
                ViewData["dateStart"] = ngaykhoihanh;
                ViewData["diadiemdon"] = "1";


                var tuyendi = bus_Ghe.LoadTuyenDi(int.Parse(noidi.ToString()), int.Parse(noiden.ToString()));
                ViewData["tuyendi"] = tuyendi;

                ViewData["diadiem"] = bus_Ghe.LoadDiaDiemDon(tuyendi[0].ID_Tuyen);
                if (ngaykhoihanh != null)
                {
                    var chuyendi = bus_Ghe.LoadChuyenDi(tuyendi[0].ID_Tuyen, ngaykhoihanh);
                    ViewData["xe"] = bus_Ghe.Load_Ghe_Xe(chuyendi[0].BienSo);
                    ViewData["giokhoihanh"] = chuyendi;
                    ViewData["chuyendi"] = chuyendi[0].ID_Chuyen;
                    ViewData["giokhoihanhfdefault"] = chuyendi[0];
                    List<VE> a = bus_Ghe.LoadGheDaDat(chuyendi[0].ID_Chuyen);
                    List<string> ghedat = new List<string>();
                    for (int i = 0; i < a.Count; i++)
                    {
                        ghedat.Add(a[i].ID_GHE.ToString());
                    }

                    var ghedadat = "";
                    for (int i = 0; i < ghedat.Count; i++)
                    {
                        if (i == ghedat.Count - 1)
                        {
                            ghedadat += ghedat[i];
                        }
                        else
                        {
                            ghedadat += ghedat[i] + ", ";
                        }
                    }

                    List<string> dataGheDaDat = new List<string>();
                    string[] dt = ghedadat.Split(',');
                    for (int i = 0; i < dt.Length; i++)
                    {
                        dataGheDaDat.Add(dt[i]);
                    }

                    ViewData["getDat"] = ghedadat;
                    if (giokhoihanh != null)
                    {
                        ViewData["xe"] = bus_Ghe.Load_Ghe_Xe(giokhoihanh);
                        ViewData["chuyendi"] = chuyendi[0].ID_Chuyen;
                        //ViewData["ghedat"] = bus_Ghe.LoadGheDaDat(chuyendi[0].ID_Chuyen);
                    }
                    else
                    {
                        ViewData["xe"] = bus_Ghe.Load_Ghe_Xe(chuyendi[0].BienSo);
                    }
                }
                return View();
            }
            catch
            {
                return RedirectToAction("Index", "DatVeChoKhach");
            }
        }
    }
}