using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website_BanVeXe.Models
{
    public class Model_DangKy
    {
        [Key]
        public int ID { get; set; }

        [Display(Name="Ten dang nhap")]
        [Required(ErrorMessage ="nhap ho ten kia")]
        public string HoTen { get; set; }

        [Display(Name = "email")]
        [Required(ErrorMessage = "nhap email kia")]

        public string Email { get; set; }

        [Display(Name = "so dien thoai")]
        [Required(ErrorMessage = "nhap sdt kia")]
        public string SDT { get; set; }

        [Display(Name = "cmnd")]
        [Required(ErrorMessage = "nhap cmnd kia")]
        public string CMND { get; set; }

        [Display(Name = "mat khau")]
        [StringLength(10,MinimumLength =4, ErrorMessage ="do dai it nhat la 4")]
        [Required(ErrorMessage = "nhap pass kia")]
        public string Pass { get; set; }

        [Display(Name = "nhaapj laji maajt khaair")]
        [Compare("Pass", ErrorMessage ="khong dung nha")]
        [Required(ErrorMessage = "nhap lai pass kia")]
        public string ConfirmPass { get; set; }

        [Display(Name = "dia chi")]
        [Required(ErrorMessage = "nhap dia chi kia")]
        public string DiaChi { get; set; }
    }
}