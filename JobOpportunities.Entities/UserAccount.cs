using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
	public class UserAccount :IEntity
	{
		//Artan sayı olacak
		public int UserAccountID { get; set; }
		public string Mail { get; set; }
		public string Password { get; set; }
		public int? RoleID { get; set; }

		//Navigation Property

		public virtual Role Role { get; set; }
		public virtual Student Student { get; set; }
		public virtual Advisor Advisor { get; set; }


	}
}
