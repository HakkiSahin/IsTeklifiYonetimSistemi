using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobOpportunities.UI.MVC.Models
{
    public class UserAccountViewModel
    {
        public string Mail { get; set; }

        [Required(ErrorMessage = "Şifre boş bırakılamaz")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre tekrarı boş bırakılamaz")]
        [Display(Name = "Şifre Tekrar")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifre uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}