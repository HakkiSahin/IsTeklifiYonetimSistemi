using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
	public class Contract:IEntity
	{
		public Contract()
		{
			Clans = new HashSet<Clan>();
		}

		public int ContractID { get; set; }
		public string ContractName { get; set; }

		//Navigation Property

		public virtual ICollection<Clan> Clans { get; set; }


	}
}
