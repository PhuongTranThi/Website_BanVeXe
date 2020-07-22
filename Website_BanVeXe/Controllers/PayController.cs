using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DTO_BanVeXe;
using BUS_BanVeXe;
using System.Net.Mail;
using System.Net;
using Website_BanVeXe.Models;

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

            if (idChuyenDi != null)
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
            string tongtien = form["donGiaNha"];
            string id_ghe = form["gheSelect"];
            string hoten = form["hoten"];
            string email = form["email"];
            string sdt = form["sdt"];
            string id_chuyendi = form["id_chuyendi"];
            string id_diadiem = form["id_diadiem"];
            string tentuyen = form["tentuyen"];
            string bienso = form["bienso"];
            string giokhoihanh = form["giokhoihanh"];
            string ngaydi = form["ngaydi"];
            string diadiemlenxe = form["diadiemlenxe"];

            DTO_DatVe dto_datve = new DTO_DatVe();
            DTO_ChuyenDi dto_chuyendi= new DTO_ChuyenDi();
            dto_datve.TongTien = float.Parse(tongtien.ToString());
            dto_datve.ID_Chuyen = int.Parse(id_chuyendi.ToString());
            dto_datve.ID_DiaDiemLenXe = int.Parse(id_diadiem.ToString());
            dto_datve.ID_Ghe = id_ghe;
            int id = -1;

            if (Session["idKH"] != null)
            {
                id = int.Parse(Session["idKH"].ToString());
            }
            dto_datve.ID_KhachHang = id;
            dto_datve.HoTenKhachHang = hoten;
            dto_datve.Email = email;
            dto_datve.SDT = sdt;
            dto_datve.DiaChi = "163 Tan Thoi Nhat 8";
            

            BUS_DatVe bus_datve = new BUS_DatVe();

            if (bus_datve.DatVe(dto_datve))
            {
               
                EmailService a = new EmailService();
             
                string smtpUserName = "tranthiphuong061298ht@gmail.com";
                string smtpPassword = "Truongcntptphcm1";
                string smtpHost = "smtp.gmail.com";
                int smtpPort = 587;

                string emailTo = email;
                string subject = "THÔNG TIN VÉ XE - NHÀ XE PHƯƠNG NGÂN";
                string body = string.Format("" +
                    "Bạn vừa nhận được liên hệ từ: <b>{0}</b><br/>Email: {1}" +
                    "<br/>" +
                    "<div>" +
                    "<div>Nội dung: </div><br/> " +
                    "<div>Tên tuyến : {2}<span> &emsp;&emsp;Biển số xe : {3}</span></div>" +
                    
                    "<div>Ngày đi: {4}<span> &emsp;&emsp;Giờ khởi hành : {5}</span></div>" +
                 
                    "<div>Danh sách ghế : {6}</div>" +
                     "<div>Địa điểm lên xe : {10}</div>" +
                    "<div>Họ tên khách hàng : {8}<span> &emsp;&emsp;Số điện thoại : {7}</span></div>" +
                    "<div>Tổng tiền : {9}</div>" +
                    "<br/>" +
                    "<div><i>Mọi thông tin đóng góp, phản ánh quý khách vui lòng gửi qua <p>Email: tranthiphuong061298ht@gmail.com</p></i></div>" +
                    "</div>", "Nhà xe Phương Ngân", "tranthiphuong061298ht@gmail.com", tentuyen, bienso, ngaydi, giokhoihanh, id_ghe, sdt, hoten, tongtien, diadiemlenxe);
                EmailService service = new EmailService();
                bool kq = service.Send(smtpUserName, smtpPassword, smtpHost, smtpPort, emailTo, subject, body);
                return RedirectToAction("Index", "Home");
            }
            else return RedirectToAction("Index", "Home");


        }

    }
}