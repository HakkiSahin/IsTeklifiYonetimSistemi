using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class Teacher : Person,IEntity
	{
        public Teacher()
        {
            Clans = new HashSet<Clan>();
        }
        

        //Navigation Property

        public ICollection<Clan> Clans { get; set; }
    }
}
