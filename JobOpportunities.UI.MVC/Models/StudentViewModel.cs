using JobOpportunities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobOpportunities.UI.MVC.Models
{
    public class StudentViewModel
    {
        [Display(Name ="İş Teklifi istiyor musunuz?")]
        public bool? IsActive { get; set; }

        [Display(Name = "Askerlik durumunuz")]
        public bool? MilitaryState { get; set; }

        [Display(Name = "En düşük Maaş Beklentiniz")]
        public int? MinimumWage { get; set; }

        [Display(Name = "Neden iş teklifi istemiyorsunuz")]
        public string StateDescription { get; set; }

        [Display(Name = "Toplam iş tecrübeniz")]
        public int? TotalExperience { get; set; }

        [Display(Name = "Bildiginiz Diller")]
        public List<Language> Languages { get; set; }

        [Display(Name = "Yetenekleriniz")]
        public List<Skill> Skills { get; set; }

        [Display(Name ="Çalışmak istediğiniz iller")]
        public List<City> Cities { get; set; }


        public string Lang { get; set; }
        public string Skill { get; set; }
        public string City { get; set; }
    }
}