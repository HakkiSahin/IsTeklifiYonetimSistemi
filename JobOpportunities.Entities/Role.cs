using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class Role : IEntity
	{
        public Role()
        {
			UserAccounts = new HashSet<UserAccount>();
        }
        public int RoleID { get; set; }
        public string RoleName { get; set; }

		//Navigation Property

		public virtual ICollection<UserAccount> UserAccounts  { get; set; }

	}
}
