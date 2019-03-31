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
    public class Student_Language : IEntity
	{
        [Key]
        [Column(Order =0)]
        public int LanguageID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int StudentID { get; set; }
        public string Level { get; set; }

        //Navigation Property
        public virtual Student Student { get; set; }
        public virtual Language Language { get; set; }

    }
}
