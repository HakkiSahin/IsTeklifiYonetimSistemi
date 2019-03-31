using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobOpportunities.UI.MVC.Models
{
    public class StudentCreateViewModel
    {

        public int ID { get; set; }

        [Display(Name = "Tc Kimlik Numarası")]
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string TCKN { get; set; }

        [Display(Name = "Adı")]
        [Required]
        [MaxLength(30)]

        public string Name { get; set; }

        [Display(Name = "Soyadı")]
        [Required]
        [MaxLength(20)]

        public string Surname { get; set; }

        [Display(Name = "Portal Numarası")]
        [Required]

        public int ClanID { get; set; }

        [Display(Name = "Cv Linki")]
        [Required]
        public string CvLink { get; set; }
    }
}