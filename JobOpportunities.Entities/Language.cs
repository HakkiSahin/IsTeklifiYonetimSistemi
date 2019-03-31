using JobOpportunities.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOpportunities.Entities
{
    public class Language : IEntity
	
    {
        public Language()
        {
            Student_Languages = new HashSet<Student_Language>();
        }
        public int LanguageID { get; set; }
        public string LanguageName { get; set; }

        //Navigation Property
        public virtual ICollection<Student_Language> Student_Languages { get; set; }
    }
}
