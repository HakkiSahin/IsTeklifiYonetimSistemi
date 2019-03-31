using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class Skill : IEntity
	{
        public Skill()
        {
            Students = new HashSet<Student>();
        }
        public int SkillID { get; set; }
        public string SkillName { get; set; }

        //Navigation Property
        public ICollection<Student> Students { get; set; }
    }
}
