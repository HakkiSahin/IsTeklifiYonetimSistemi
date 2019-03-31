using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
	public class Department:IEntity
	{
		public Department()
		{
			Clans = new HashSet<Clan>();
		}
		public int DepartmentID { get; set; }
		public string DepartmentName { get; set; }

		//Navigation Property

		public virtual ICollection<Clan> Clans { get; set; }
	}
}
