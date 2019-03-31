using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class Clan : IEntity
	
    {
        public Clan()
        {
            Students = new HashSet<Student>();
        }
		public int ClanID { get; set; }
		public int ContractID { get; set; }
		public int DepartmentID { get; set; }
		public string PortalNo { get; set; }
		public string Term { get; set; }
		public string GroupClass { get; set; }
        public int? TeacherID { get; set; }

		//Navigation Property
		public virtual  Department Department { get; set; }
		public virtual Contract Contract { get; set; }
		public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        

    }
}
