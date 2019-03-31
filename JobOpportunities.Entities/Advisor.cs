using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class Advisor : Person,IEntity
    {
		//Otomatik sayı olmayacak UserAccount sayfasına eklenecek oraya eklenen son UserAccountID buranın
		//ID si olacak
		
		


		//Navigation Property

		public virtual UserAccount UserAccount { get; set; }



	}
}
