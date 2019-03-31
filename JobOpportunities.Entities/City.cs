using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class City:IEntity
    {
        public City()
        {
            Students = new HashSet<Student>();
        }
        public int CityID { get; set; }
        public string CityName { get; set; }

        //Navigation Property
        public virtual ICollection<Student> Students { get; set; }
    }
}
