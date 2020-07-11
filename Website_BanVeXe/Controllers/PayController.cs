using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO_BanVeXe;
using BUS_BanVeXe;

namespace Website_BanVeXe.Controllers
{
    public class PayController : Controller
    {
        // GET: Pay
        public ActionResult Index(FormCollection form)
        {
            string ngaydat = form["ngaydat"];
           
          
            string id_diadiemlenxe = form["id_diadiemlenxe"];
            string id_ghe = form["id_ghe"];
            string id_khachhang = form["id_khachhang"];
            string hoten = form["hoten"];
            string email = form["email"];
            string sdt = form["sdt"];
            string diachi = form["diachi"];
            string dateStart = form["dateStart"];

            var idChuyenDi = form["idChuyenDi"];
            var diadiemSelect = form["diadiemSelect"];
            var gheSelect = form["gheSelect"];
            var donGiaNha = form["donGiaNha"];

            ViewData["ngaydat"] = ngaydat;
           
            
            ViewData["id_diadiemlenxe"] = id_diadiemlenxe;
            ViewData["id_ghe"] = id_ghe;
            ViewData["id_khachhang"] = id_khachhang;
            ViewData["hoten"] = hoten;
            ViewData["email"] = email;
            ViewData["sdt"] = sdt;
            ViewData["diachi"] = diachi;
            ViewData["dateStart"] = dateStart;

            ViewData["idChuyenDi"] = idChuyenDi;
            ViewData["diadiemSelect"] = diadiemSelect;
            ViewData["gheSelect"] = gheSelect;
            ViewData["donGiaNha"] = donGiaNha;

            if(idChuyenDi != null)
            {
                BUS_ChuyenDi bus_chuyendi = new BUS_ChuyenDi();

                var chuyen = bus_chuyendi.Load_Tuyen_BienSo(int.Parse(idChuyenDi));

                ViewData["tuyen_bienso"] = chuyen;

                // [{tendd:"ten"}, {tendd:"ten2"}]
                var diadiem = bus_chuyendi.LoadDiaDiemLenXe(int.Parse(diadiemSelect.ToString()))[0].TENDD.ToString();

                ViewData["diadiem"] = diadiem;

               
            }
            return View();



        }

        [HttpPost]
        public ActionResult DatVe(FormCollection form)
        {
           
            if (1== 1)
                {
                //string ngaydat = form["ngaydat"];
                string tongtien = form["donGiaNha"];
               
                string id_ghe = form["gheSelect"];
                //string id_khachhang = form["id_khachhang"];
                string hoten = form["hoten"];
                string email = form["email"];
                string sdt = form["sdt"];
                string id_chuyendi = form["id_chuyendi"];
                string id_diadiem = form["id_diadiem"];
                //string diachi = form["diachi"];

                //string ngaydat = "2020-06-29";
                //string tongtien = "230000";
                //string id_chuyen = "1";
                //string id_diadiemlenxe = "1";
                //string id_ghe = "2,3";
                //string id_khachhang = "1";
                //string hoten = "hihi";
                //string email = "hihi";
                //string sdt = "06545454884";
                //string diachi = "hihi";

                DTO_DatVe dto_datve = new DTO_DatVe();
                dto_datve.TongTien = float.Parse(tongtien.ToString());
                dto_datve.ID_Chuyen = int.Parse(id_chuyendi.ToString());
                    dto_datve.ID_DiaDiemLenXe = int.Parse(id_diadiem.ToString());
                dto_datve.ID_Ghe = id_ghe;
                var id = int.Parse(Session["idKH"].ToString());
                dto_datve.ID_KhachHang = int.Parse(Session["idKH"].ToString());
                dto_datve.HoTenKhachHang = hoten;
                    dto_datve.Email = email;
                    dto_datve.SDT = sdt;
                dto_datve.DiaChi = "163 Tan Thoi Nhat 8";


                BUS_DatVe bus_datve = new BUS_DatVe();

                    if (bus_datve.DatVe(dto_datve))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else return RedirectToAction("Index", "Home");
                }
 

        }

    }
}